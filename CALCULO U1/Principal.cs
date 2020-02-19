using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALCULO_U1
{
    public class Principal:Vector
    {
        int V;
        public void Bienvenida()
        {
            Console.WriteLine("Bienvenido a la calculadora de vectores!");
            Console.WriteLine("");
            Console.WriteLine("Integrantes: ");
            Console.WriteLine("");
            Console.WriteLine(" - Garcia Rodriguez Alan");
            Console.WriteLine(" - Paniagua Ayala Isaias");
            Console.WriteLine(" - Gutierrez Vizcarra Daniel");
            Console.WriteLine("");
            Console.WriteLine("debera ingresar sus dos vectores para seleccionar la operacion que necesite...");
            Console.ReadKey();
            Console.Clear();
            Ingresar();
        }

        public void Ingresar()
        {
            try
            {
                Console.WriteLine("Ingrese el vector 1 con sus correspondientes ' i , j , k '");
                Console.WriteLine("");
                Console.WriteLine("i :");
                i1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine("j :");
                j1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine("k :");
                k1 = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                Console.WriteLine("Ingrese el vector 2 con sus correspondientes ' i , j , k '");
                Console.WriteLine("");
                Console.WriteLine("i :");
                i2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine("j :");
                j2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine("k :");
                k2 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
            catch (Exception ex)
            {
                Error(ex);
            }

            Console.WriteLine("");
            Menu();
        }
        public void Menu()
        {
            Console.WriteLine(" Vector 1: " + i1 + "i" + " " + j1 + "j" + " " + k1 + "k");
            Console.WriteLine(" Vector 2: " + i2 + "i" + " " + j2 + "j" + " " + k2 + "k");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Elige una de las siguientes opciones"+ "\n------------------------------------"+
                "\n1.-Suma de Vectores" +"\n2.-Producto Punto"+
                "\n3.-Producto escalar"+ "\n4.-Angulo de 2 Vectores"+
                "\n5.-Vector Resultante" + "\n6.-Proyección de un Vector");
            Console.WriteLine("");

            try
            {
                V = Convert.ToInt32(Console.ReadLine());

                switch (V)
                {
                    case 1:
                        Console.Clear();
                        SumaVectores();
                        break;

                    case 2:
                        Console.Clear();
                        ProductoPunto();
                        Regresar();
                        break;

                    case 3:
                        Console.Clear();
                        ProductoCruz();
                        break;
                    case 4:
                        Console.Clear();
                        SacarAngulo();
                        break;
                    case 5:
                        Console.Clear();
                        VectorR();
                        break;
                    case 6:
                        Console.Clear();
                        Proyeccion();
                        break;
                    default:
                        Console.WriteLine("Esta opcion no existe");
                        Console.ReadKey();
                        break;
                }
            }
            catch (Exception ex)
            {
                ErrorMenu(ex);
            }
        }

        public void SumaVectores()
        {
            int Ri,Rj,Rk;

            Ri = i1 + i2;
            Rj = j1 + j2;
            Rk = k1 + k2;

            Console.WriteLine("Suma de Vectores: " + Ri + "i" + " " + Rj + "j" + " " + Rk + "k");
            Regresar();
        }

        public void ProductoPunto()
        {
            Resul = ((i1 * i2) + (j1 * j2) + (k1 * k2));

            Console.WriteLine("Producto Punto de los vectores: " + Resul);
        }

        public void ProductoCruz()
        {
            int Ri, Rj, Rk;

            Ri = ((j1 * k2) + (k1 * j2 * (-1)));
            Rj = ((-1) * ((i1 * k2) + (i2 * k1 * (-1))));
            Rk = ((i1 * j2) + (j1 * i2 * (-1)));

            Console.WriteLine("Producto cruz de los vectores: " + Ri + "i" + " " + Rj + "j" + " "  + Rk + "k");
            Regresar();
        }
        public void SacarAngulo()
        {
            ProductoPunto();
            Console.Clear();
            double V1 = Math.Pow(i1, 2) + Math.Pow(j1, 2) + Math.Pow(k1, 2);
            double V2 = Math.Pow(i2, 2) + Math.Pow(j2, 2) + Math.Pow(k2, 2);
            double Rv1 = Math.Sqrt(V1);
            double Rv2 = Math.Sqrt(V2);
            Angulo =Math.Acos(Resul / (Rv1 * Rv2)) * 57.2958;
            Console.WriteLine("El angulo es: "+ Angulo);
            Regresar();
        }
        public void VectorR()
        {
            ProductoPunto();
            Console.Clear();
            Console.WriteLine("A = ("+i1+"i,"+j1+"j,"+k1+"k)");
            Console.WriteLine("B = (" + i2 + "i," + j2 + "j," + k2 + "k)");
            Console.WriteLine("");
            Console.WriteLine("Ingresa el valor que multiplicara el vector A");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el valor que multiplicara el vector B");
            int b = int.Parse(Console.ReadLine());
            i1 = a * i1; j1 = a * j1; k1 = a * k1;
            i2 = b * i2; j2 = b * j2; k2 = b * k2;
            i1 = i1 + i2; j1 = j1 + j2; k1 = k1 + k2;
            Console.WriteLine("Vector Resultante = "+ "\n(" + i1 + "i," + j1 + "j," + k1+ "k)");
            Regresar();
        }
        public void Proyeccion()
        {
            ProductoPunto();
            Console.Clear();
            double V2 = Math.Pow(i2, 2) + Math.Pow(j2, 2) + Math.Pow(k2, 2);
            double r, i, j, k;
            r = Resul / V2;
            i = r * i2; j = r * j2; k = r * k2;
            Console.WriteLine("La Proyeccion del Vector es = " + "\n(" + i + "i," + j + "j," + k + "k)");
            Regresar();
        }
        public void ErrorMenu(Exception ex)
        {
            Console.WriteLine("");
            Console.WriteLine("No dejes espacio...");
            Console.ReadKey();
            Console.Clear();
            Menu();
        }
        public void Error(Exception ex)
        {
            Console.WriteLine("");
            Console.WriteLine("Ingresa unicamente numeros enteros...");
            Console.ReadKey();
            Console.Clear();
            Ingresar();
        }

        public void Regresar()
        {
            Console.WriteLine("");
            Console.WriteLine("Presione cualquier tecla para volver al menu...");
            Console.ReadKey();
            Console.Clear();
            Ingresar();
        }
    }
}
