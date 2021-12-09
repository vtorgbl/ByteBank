﻿using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Sistemas
{
    class SistemaInterno
    {
        public bool Logar(IAutenticavel funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);

            if (usuarioAutenticado) 
            { 
                Console.WriteLine("Bem-vindo ao sistema!"); 
                return true; 
            }
            else 
                Console.WriteLine("Senha ou e-mail incorretos"); 
                return false;
        }
    }
}
