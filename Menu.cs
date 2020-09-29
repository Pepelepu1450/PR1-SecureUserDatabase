using System;
using System.Collections.Generic;

namespace PR3_SecureUserDatabase
{
    class Menu 
    {
     /*
     registrar
     consultar
     salir
     */

    List<int> RegistroMenu = new List<int>(new int[]{1,2,9});
    private const int salir = 9;
    List<Usuario> UsuariosAceptados = new List<Usuario>();

    private void MensajeDeBienvenida(){
        System.Console.WriteLine("bienvenido a nuestro sistema de seguirdad");
        System.Console.WriteLine();
    }
    private void OpcionesMenu()
    {
        System.Console.WriteLine("1) registrar usario");
        System.Console.WriteLine("2) consultar usario");
        System.Console.WriteLine("9) salir");
    }

    private void MensajeDeDespedida(){
        System.Console.WriteLine("gracias por confiar en nuestro sistema de seguridad");
    }

        private int RequestOption(List<int> validOptions)
        {
            int userInputAsInt = 0;
            bool isUserInputValid = false;

            //Mientras no haya una respuesta válida
            while (!isUserInputValid)
            {
                System.Console.WriteLine("Selecciona una opción:");
                string userInput = System.Console.ReadLine();


                try
                {
                    userInputAsInt = Convert.ToInt32(userInput);
                    isUserInputValid = validOptions.Contains(userInputAsInt);
                }
                catch (System.Exception)
                {
                    isUserInputValid = false;
                }


                if (!isUserInputValid)
                {
                    System.Console.WriteLine("La opción seleccionada no es válida.");
                }
            }

            return userInputAsInt;
        }

    private void registrar(){
        /*
        nombre
        id
        clave
        valido o no
        TO DO: implementar autorizar o rechar el identificador
        */
        System.Console.WriteLine("ingresa nombre");
        string ingresarNombre = Convert.ToString(Console.ReadLine());
        System.Console.WriteLine("ingresa id");
        string ingresarIdentificador = Convert.ToString(Console.ReadLine());
        string autorizacion = "aturizado";
        System.Console.WriteLine("ingresa clave");
        string clave = Convert.ToString(Console.ReadLine());
        UsuariosAceptados.Add(new Usuario(ingresarNombre, ingresarIdentificador, clave, autorizacion)); 

    }
    
    private void consultar(){   
        for (int i = UsuariosAceptados.Count - 1; i >= 0; i--)
        {
            System.Console.WriteLine($"{UsuariosAceptados[i].Nombres()} - {UsuariosAceptados[i].Identificador()} - {UsuariosAceptados[i].Clave()} - {UsuariosAceptados[i].Autorizacion()}");
        }


    }

        //TO DO: implementar el sistema de seguridad para los usuarios
        public void Display()
        {
            int selectedOption = 0;

            MensajeDeBienvenida();

            while (selectedOption != salir)
            {
                OpcionesMenu();

                selectedOption = RequestOption(RegistroMenu);

                switch (selectedOption)
                {
                    case 1:
                    registrar();
                    break;

                    case 2:
                    consultar();
                    break;
                }
            }
            MensajeDeDespedida();

        }

    }
}
