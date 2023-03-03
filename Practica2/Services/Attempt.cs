using System;
using WSDL.mensajes;

namespace WSDL.operaciones{
    public class Operaciones : Mensajes{
        public string Saludar(string nombre){
            string msj = "Hola " +nombre;
            int id=0;
            int[] ids;
            string[] nombres; 
            for(int i=0;i<10;i++){
                nombres[i] = nombre;
                ids[i] = id+i;
            }


            return msj;
        }

        public string Mostrar(int id){
            for(int i=0;i>10;i++){
                if(nombres[i]=ids[i])}
                return "id";
            }
            
        }
    }