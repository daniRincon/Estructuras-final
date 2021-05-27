using System;

public class Ventas
{

   private int concombos = 0, concombos2 = 0, concrispetas = 0, concrispetas2 = 0, concrispetas3 = 0, 
        congaseosa = 0, congaseosa2 = 0, congaseosa3 = 0, edad1 = 0, edad2 = 0, edad3 = 0, edad4 = 0;
   private long dinero_comida, dinero_taquilla;
    public Ventas()
	{



    }
       
    public void taquilla()
        {
			
			int dinero ;
            int opc;
        do
        {

            Console.WriteLine("su edad esta entre: ");
            Console.WriteLine("");
            Console.WriteLine("1. 0 años a 5 años");
            Console.WriteLine("2. 5 años a 18 años");
            Console.WriteLine("3. 19 años a 50");
            Console.WriteLine("4. mayor de 50");
            opc = int.Parse(Console.ReadLine());
        } while (opc < 1 && opc > 4);

        switch (opc)
        {

            case 1:
                dinero = 5000;
                edad1++;
                edad1 += dinero;
                break;


            case 2:
                dinero = 6000;
                edad2++;
                edad2 += dinero;
                break;

            case 3:
                dinero = 8000;
                edad3++;
                edad3 += dinero;
                break;

            case 4:
                dinero = 7000;
                edad4++;
                edad4 += dinero;
                break;
        }

        dinero_taquilla = edad1 + edad2 + edad3 + edad4;

    }
    
    
    public void comida()
        {
            int opc, crispetas, crispetasM, crispetasG,  combos, combos2, gaseosa, gaseosa2, gaseosa3; 
            
            do
            {
                Console.WriteLine("Desea Comprar Comida");
                Console.WriteLine("");
                Console.WriteLine("1. Si");
                Console.WriteLine("2. No");
                 opc = int.Parse(Console.ReadLine());
                if (opc < 1 && opc > 2)
                {
                    Console.WriteLine("Ingrese una opcion valida");
                }
            } while (opc < 1 && opc > 2);
           int concombos = 0, concombos2 = 0,  concrispetas = 0, concrispetas2 = 0, concrispetas3 = 0, congaseosa = 0, congaseosa2 = 0, congaseosa3 = 0;
            long dinero_comida;

            //menu comida
            switch (opc)
            {
                //si desea comprar comida
                case 1:
                   
                    do
                    {
                        Console.WriteLine("¿Qué desea comprar?");
                        Console.WriteLine("");
                        Console.WriteLine("1. Combos");
                        Console.WriteLine("2. Crispetas");
                        Console.WriteLine("3. Gaseosa");                                               
                        Console.WriteLine("4 Salir");
                        opc = int.Parse(Console.ReadLine());
                        if (opc < 1 && opc > 4)
                        {
                            Console.WriteLine("Ingrese una opcion valida");
                        }
                    } while (opc < 1 && opc > 4);

                    //sub menu de lo que desea comprar
                    switch (opc)
                    {
                        case 1:

                            do
                            {
                                Console.WriteLine("Combos");
                                Console.WriteLine("");
                                Console.WriteLine("1. Combos 1 \n Contiene: ('Crispetas mediana + Gaseosa + Chocolatina') con un precio de 25.000 pesos");
                                Console.WriteLine("");
                                Console.WriteLine("2. Combos 2 \n Contiene: ('Crispetas grande + Gaseosa + Chocolatina + perro o hamburguesa') con un precio de 40.000 pesos");
                                 opc = int.Parse(Console.ReadLine());
                                if(opc < 1 && opc > 2)
                                {
                                    Console.WriteLine("Ingrese una opcion valida");
                                }
                               
                            } while (opc < 1 && opc > 2);

                            //combos
                            switch (opc)
                            {
                                case 1:
                                    combos = 25000;
                                    concombos++;

                                concombos += combos;
                                    break;

                                case 2:
                                    combos2 = 40000;
                                    concombos2++;

                                concombos2 += combos2;
                                    break;

                            }

                            break;

                        //crispetas
                        case 2:
                        do
                        {
                            Console.WriteLine("Crispetas");
                            Console.WriteLine("");
                            Console.WriteLine("1. Crispeta pequeña   $6.000 pesos ");
                            Console.WriteLine("2. Crispeta Mediana   $11.000 pesos ");
                            Console.WriteLine("3. Crispeta Grande    $20.000 pesos ");
                            opc = int.Parse(Console.ReadLine());
                            if (opc < 1 && opc > 2)
                            {
                                Console.WriteLine("Ingrese una opcion valida");
                            }

                        } while (opc < 1 && opc > 3);

                        switch (opc)
                        {
                            case 1:
                                crispetas = 6000;
                                concrispetas++;

                                concrispetas += crispetas;
                                break;


                            case 2:
                                crispetasM = 11000;
                                concrispetas2++;

                                concrispetas2 += crispetasM;
                                break;


                            case 3:
                                crispetasG = 20000;
                                concrispetas3++;

                                concrispetas3 += crispetasG;
                                break;
                        }


                        break;


                        //gaceosas
                        case 3:

                        do
                        {
                            Console.WriteLine("Combos");
                            Console.WriteLine("");
                            Console.WriteLine("1. Gaseosa mini  $1.500 ");
                            Console.WriteLine("2. Gaseosa 1L    $2.500");
                            Console.WriteLine("3. Gaseosa 1.5L  $5.000");
                            opc = int.Parse(Console.ReadLine());
                            if (opc < 1 && opc > 2)
                            {
                                Console.WriteLine("Ingrese una opcion valida");
                            }

                        } while (opc < 1 && opc > 2);



                        switch (opc)
                        {
                            case 1:
                                gaseosa = 1500;
                                congaseosa++;

                                congaseosa += gaseosa;
                                break;


                            case 2:
                                gaseosa2 = 2500;
                                congaseosa2++;

                                congaseosa2 += gaseosa2;
                                break;


                            case 3:
                                gaseosa3 = 5000;
                                congaseosa3++;

                                congaseosa3 += gaseosa3;

                                break;
                        }



                        break;


                        case 4:

                            break;

                       

                       
                    }


                break;

                case 2:

                Console.WriteLine("Siga a la sala");

                    break;
            }

        dinero_comida = concombos + concombos2 + concrispetas + concrispetas2 + concrispetas3 + congaseosa + congaseosa2 + congaseosa3;

    }
}
