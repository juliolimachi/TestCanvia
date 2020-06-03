using DAL;
using ET;
using System.Collections.Generic;

namespace BL
{
    public  class PersonaBL
    {
        private PersonaDAL personaDAL = new PersonaDAL();

        public List<Persona> Listar()
        {
            return personaDAL.Listar();
        }


        public bool Registrar(Persona persona)
        {
            return personaDAL.Registrar(persona);
        }

    }
}
