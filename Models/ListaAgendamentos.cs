using System;
using System.Collections.Generic;
namespace PetVet.Models
{
    public class ListaAgendamentos
    {
        public static List<Agendar> ListaAgendar = new List<Agendar>();

        public static void Adicionar(Agendar animal) => ListaAgendar.Add(animal);

        public static List<Agendar> Listar()
        {
            return ListaAgendar;
        }
    }
}