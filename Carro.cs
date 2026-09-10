using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    internal class Carro
    {
        private int _velocidadeAtual;

        public int VelocidadeAtual
        {
            get { return _velocidadeAtual; }
        }
        public void Acelerar()
        {
            _velocidadeAtual += 10;
        }

        public void Frear()
        {
            if (_velocidadeAtual >= 10)
            {
                _velocidadeAtual -= 10;
            }
            else
            {
                _velocidadeAtual = 0;
            }
        }
    }
}