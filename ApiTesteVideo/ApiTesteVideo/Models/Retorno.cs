using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiTesteVideo.Models
{
    public class Retorno
    {
        public string Mensagem { get; set; }
        public string Status { get; set; }
        public DateTime Data { get; set; }

        public static List<Retorno> ObterRetorno()
        {
            List<Retorno> retornos = new List<Retorno>();
            retornos.Add(new Retorno()
            {
                Mensagem = "Hello World",
                Status = "OK",
                Data = DateTime.Now
            });

            retornos.Add(new Retorno()
            {
                Mensagem = "Olá mundo",
                Status = "Segundo",
                Data = DateTime.Now.AddDays(-1)
            });

            return retornos;
        }
    }
}