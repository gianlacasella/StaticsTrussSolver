# Importamos modulos utiles
from matplotlib import pyplot as pt
import scipy as sc
import scipy.linalg as lin

# Definimos nuestro array con los nodos
xy = sc.array(
	[
	#Nodo 0
	[0,0],
	#Nodo 1
	[3,0],
	#Nodo 2
	[3,4],
	#Nodo 3
	[9,0],
	#Nodo 4
	[9,4],
	#Nodo 5
	[12,0]
	])

#Definimos las conexiones entre las barras
conectividad = [
#Primera conexion
[0,1],
#Segunda conexion
[0,2],
#Tercera conexion
[1,2],
#Cuarta conexion
[1,4],
#Quinta conexion
[1,3],
#Sexta conexion
[2,4],
#Septima conexion
[3,4],
#Octava conexion
[3,5],
#Novena conexion
[5,4]
]

# Definimos las restricciones que tiene el sistema
restric = [
#Restriccion del soporte deslizante
[0, sc.pi/2],
#Restricciones del soporte fijo
[5, sc.pi/2],
[5, 0.]
]

# Definimos las fuerzas externas que se aplican al sistema
fuerzas = [
#Primera fuerza vertical de 3kN
[1, 0.,-3000],
#Segunda fuerza vertical de 5kN
[3, 0., -5000],
#Tercera fuerza vertical de 2kN
[4, 2000, 0.]
]

# Definimos el numero de ecuaciones
n = xy.shape[0]
# La cantidad de barras
b = len(conectividad)
# Y la cantidad de restricciones
r = len(restric)

# Determinamos el grado de inteterminacion estatica
GIE = b+r - 2*n
print('b: ', b, 'r: ',r, 'n: ', n)

# Lo mostramos
print("\n\nEl GIE del problema es "+ str(GIE))

# Salimos con mensaje de error si el sistema es hiperestatico o es un mecanismo
if GIE > 0 :
	print("El problema es hiperestatico")
	exit(-1)
elif GIE < 0 :
	print("El problema es un mecanismo")
	exit(-1)
# Si no, se puede resolver y seguimos
else:
	print("\n\nEl problema se puede resolver")

# Definimos nuestra matriz C y el vector f (es necesario trasponer f para que se considere como un vector)
C = sc.asmatrix(sc.zeros((2*n, b+r), dtype = sc.double))
f = sc.asmatrix(sc.zeros(2*n, dtype = sc.double)).T

# Agregamos los puntos al grafico
pt.plot(xy[:, 0], xy[:, 1], "ok")

# Recorremos las conexiones para llenar la matriz C
k = 0

for barra in conectividad:
	#Recorremos barra por barra las conexiones, y guardamos en ni y nj los nodos de conexion
	ni = barra[0]
	nj = barra[1]
	# Guardamos en x y en y los puntos
	x = xy[barra,0]
	y = xy[barra,1]
	# Calculamos la mitad de la longitud de las barras usando scipy.mean()
	x0 = sc.mean(x)
	y0 = sc.mean(y)
	# Calculamos el theta para cada barra
	theta = sc.arctan2(y[1] - y[0], x[1] - x[0])
	# Vamos llenando nuestra matriz con los valores necesarios de las barras
	C[2*ni, k] = sc.cos(theta)
	C[2*ni+1, k] = sc.sin(theta)
	C[2*nj, k] = -sc.cos(theta)
	C[2*nj+1, k] = -sc.sin(theta)
	k+=1

# Recorremos las restricciones
for rest in restric:
	# Guardamos en nodo el nodo correspondiente
	nodo = rest[0]
	# Guardamos en alpha el angulo que se forma
	alpha = rest[1]
	# Agregamos a la matriz C los valores necesarios  de las restricciones
	C[2*nodo, k] = sc.cos(alpha)
	C[2*nodo+1, k] = sc.sin(alpha)
	k += 1

# Recorremos las fuerzas
for fuerza in fuerzas:
	# Guardamos en nodo el punto de aplicacion de la fuerza
	nodo = fuerza[0]
	# Guardamos en fx y fy las componentes x e y de la fuerza
	fx = fuerza[1]
	fy = fuerza[2]
	# Agregamos las fuerzas a nuestro vector f
	f[2*nodo] = fx
	f[2*nodo+1] = fy

# Fijamos los tamanios de los ejes cartesianos
pt.ylim(bottom = -3, top = 5)
pt.xlim(left = -3, right = 15)

# Resolvemos el sistema
r = lin.solve(C, -f)

# Colores minimos y maximos para las intensidades de los colores de las barras
# Los vectores representan intensidades [R,G,B]
cmin = sc.array([1,0,0], dtype = sc.double)
cmax = sc.array([0,0,1], dtype = sc.double)

# Hallamos la fuerza mas pequena y la mas grande dentro del vector solucion, que tendran
# el valor maximo y minimo de los colores. Uno va a ser totalmente azul, y el otro totalmente rojo
#[COMPRESION]--> rojo [TRACCION]--> azul
rmax = r.max()
rmin = r.min()


# Recorremos de nuevo las barras
k=0
for barra in conectividad:
	# Obtenemos la solucion de nuestro vector r
	rk = r[k, 0]
	# Calculamos el color que deberia tener la barra a partir de la intensidad de la fuerza
	xi = (rk-rmin)/(rmax - rmin)
	c = cmin*(1-xi) + cmax*xi
	# Guardamos en ni y nj los nodos que componen la barra
	ni = barra[0]
	nj = barra[1]
	# Guardamos en x e y los puntos
	x = xy[barra,0]
	y = xy[barra,1]
	# Calculamos la mitad de las barras usando scipy.mean()
	x0 = sc.mean(x)
	y0 = sc.mean(y)
	# Mostramos la barra con el color asignado
	pt.plot(x,y,color = c,linewidth = 2)
	# Dividimos entre 1000 para mostrar los resultados en kN
	rk = rk/1000
	# Agregamos el texto con el valor de la barra justo en el medio de la barra
	# Movemos el texto ligeramente a la izquierda para que se vea un poco mejor, y aumentamos su tamanio a 14
	pt.text(x0-0.5,y0,"{0:4.2f}kN".format(rk), fontsize = 14, color = "k")
	k+=1

ax = pt.axes()

# Agregamos los vectores de las cargas externas y el texto correspondiente a cada fuerza externa
ax.arrow(3.0, 0.0, 0.0, -1.0, fc = 'black', head_width = 0.2, head_length = 0.2, ec = "black")
pt.text(2.7, -1.7, "3 kN", fontsize = 12)
ax.arrow(9.0, 0.0, 0.0, -1.0, fc = 'black', head_width = 0.2, head_length = 0.2, ec = "black")
pt.text(8.7, -1.7, "5 kN", fontsize = 12)
ax.arrow(9.0, 4.0, 1.0, 0.0, fc = 'black', head_width = 0.2, head_length = 0.2, ec = "black")
pt.text(10.3, 3.9, "2 kN", fontsize = 12)


# Agregamos las etiquetas en cada punto del reticulado
pt.text(-0.2, 0.3, "A")
pt.text(3, 4.3, "B")
pt.text(9, 4.3, "C")
pt.text(12, 0.3, "D")
pt.text(3.2, -0.5, "F")
pt.text(9.2, -0.5, "E")

# Agregamos las reacciones de los soportes
# Reaccion en el soporte en A
ax.arrow(0.0, -1.3, 0.0, 1.0, fc = 'black', head_width = 0.2, head_length = 0.2, ec = "black")
pt.text(-0.3, -1.6, "{0:4.2f}kN".format(r[9][0]/1000), fontsize = 12)

# Reaccion vertical en el soporte en D
ax.arrow(12.0, -1.3, 0.0, 1.0, fc = 'black', head_width = 0.2, head_length = 0.2, ec = "black")
pt.text(11.7, -1.6, "{0:4.2f}kN".format(r[10][0]/1000), fontsize = 12)

# Reaccion horizontal en el soporte en D
ax.arrow(13.3, 0.0, -1.0, 0.0, fc = 'black', head_width = 0.2, head_length = 0.2, ec = "black")
pt.text(13.4, 0.0, "{0:4.2f}kN".format(r[11][0]/1000), fontsize = 12)

# Le ponemos titulo al grafico
pt.title("Solucion del problema 1 - Natalia Espinola/Gianfranco Lacasella")
# Mostramos el resultado
pt.show()

 # Imprimimos el vector solucion
print("\n\nEl vector solucion es: ")
print(r)

# Imprimimos los valores de las reacciones por consola
print("\nDe donde se obtiene que: \n")
print(" 1) La reaccion en el apoyo deslizante en A es: " + str(r[9][0]/1000) + " kN")
print(" 2) La reaccion horizontal en el apoyo fijo en D es: " + str(r[11][0] / 1000) + " kN")
print(" 3) La reaccion vertical en el apoyo fijo en D es: " + str(r[10][0] / 1000) + " kN")

