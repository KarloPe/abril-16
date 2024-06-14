namespace miLibreria {

    class Ej0{

        static void xMain() {

            //declaracion de variables
            int entero;
            string estrin;
            char cara;
            bool bul;
            float flota;

            //asignacion de valores
            entero=123;
            estrin="sale con fritas";
            cara='z' ;
            bul=false;
            flota=2.6464f;


            //presentacion x pantalla
            Console.WriteLine("Hola");
            Console.WriteLine(entero);
            Console.WriteLine (estrin);
            Console.WriteLine (cara);
            Console.WriteLine (bul);
            Console.WriteLine (flota);
            
        }

    }

    class Ej2{

        static void xxMain() {
        
            /*    
            //declaracion de variables
            int cont=0;
            /*

            //presentacion x pantalla
            while (cont !=0)
            {
                cont ++;
                Console.WriteLine (cont);
        
            }
            */

            for (int cont=1;cont != 6 ;cont++){
                Console.WriteLine (cont);

            }

                    
        }

    }

    class Ej3 {//ingresar x consola y mostrar en pantalla, datos tipo string, fin c cadena X

        static void Main () {

            string cade="a";

            while (cade != "x"){
                Console.Write ("ingrese frase: ");
                cade=Console.ReadLine();

                Console.WriteLine ("pusiste: {0}",cade);
            }


        }
    }

}