using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using ClassLibrary1;

namespace Municipalidad_Buena
{
    class Program
    {
        static void Main(string[] args)
        {
            //Como existe problemas de contencion, no se pueden crear obejtos de las clases persona y address por lo que tampoco se pueden crear objetos de la clase car
            List<Person> personas = new List<Person>();
            List<Car> Autos = new List<Car>();
            List<Address> propiedades = new List<Address>();

            /*A continuación hay una serie de métodos que permiten dar funcionalidad
            a un programa de gestion de la municipalidad, el programa gestor de la 
            municipalidad solamente se encargaria de los inputs y los outputs del programa*/
            void InscribirPersona(Person persona)
            {
                personas.Add(persona);

            }

            void Adoptar(Person adoptado, Person Padre)
            {
                adoptado.getAdopted(Padre);
            }

            void Adoptar2(Person adoptado, Person padre1, Person padre2)
            {
                adoptado.getAdopted(padre1, padre2);
            }

            void CambiarFirstNombre(Person persona, string nuevoNombre)
            {
                persona.changeFirstName(nuevoNombre);
            }

            void CambiarLastNombre(Person persona, string nuevoNombre)
            {
                persona.changeLastName(nuevoNombre);
            }

            void abandonarCauroChico(Person persona)
            {
                persona.getAbandoned();
            }

            void DarEducacion(Person persona, string almaMater, string n)
            {
                persona.setEducation(almaMater, n);
            }

            void CambiarDueñoPersona(Person persona, Person dueño)
            {
                persona.giveUpOwnershipToThirdParty(dueño);
            }

            void añadirDormitorios(Address propiedad, int dormitorios)
            {
                propiedad.addBeedrooms(dormitorios);
            }

            void añadirBaños(Address propiedad, int baños)
            {
                propiedad.addBathrooms(baños);
            }

            void CambiarDueñoPropiedad(Address propiedad, Person persona)
            {
                propiedad.changeOwner(persona);
            }

            void CambiarDueñoAuto(Car auto, Person persona)
            {
                auto.giveUpOwnershipToThirdParty(persona);
            }


        }
    }
}
