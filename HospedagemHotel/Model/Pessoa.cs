using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospedagemHotel.Model;

public class Pessoa
{
    public Pessoa(string nome, string sobrenom)
    {
        Nome = nome;
        Sobrenome = sobrenom;
    }
    public string Nome { get; set; }
    public string Sobrenome { get; set; }
}