using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graficos_por_tortuga
{
    class Tortuga
    {
        private const int Tamano_Alto = 20; //TAMANO PISO
        private const int Tamano_Ancho = 20;
        private int x = 1; //SE INICIA CON LA TORTUGA UBICADA EN (0,0)
        private int y = 1;
        int[,] Piso;
        int[,] A;
        int comando = 1; //SE RECIBEN LOS COMANDOS.
        int pluma1 = -1; //LA PLUMA SE INICIA HACIA ABAJO.
        char direccion = 'h'; //LA DIRECCION HACIA LA QUE VE LA TORTUGA ES HORIZONTAL
        char avanza_o_retrocede = 'a';
        string[,] cad = new string[21, 21];

        public int _pluma1
        {
            set { pluma1 = value; }
        }

        public TortugaTablero()
        {
            Piso = new int[Tamano_Ancho + 1, Tamano_Alto + 1];
            A = new int[Tamano_Ancho + 1, Tamano_Alto + 1];
            for (short i = 0; i < 20; i++)
            {
                for (short j = 0; j < 20; j++)
                {
                    Piso[i, j] = 0;
                    A[i, j] = 0;
                }
            }
        }

        public void GirarDerecha()
        {
            if ('v' == direccion)
            {
                if ('a' == avanza_o_retrocede)
                {
                    direccion = 'h';
                    avanza_o_retrocede = 'r';
                }
                else
                {
                    direccion = 'h';
                    avanza_o_retrocede = 'a';
                }
            }
            else
            {
                if ('a' == avanza_o_retrocede)
                {
                    direccion = 'v';
                    avanza_o_retrocede = 'a';
                }
                else
                {
                    direccion = 'v';
                    avanza_o_retrocede = 'r';
                }
            }
        }

        public void GirarIzquierda()
        {
            if (direccion == 'v')
            {
                if (avanza_o_retrocede == 'a')
                {
                    direccion = 'h';
                    avanza_o_retrocede = 'a';
                }
                else
                {
                    direccion = 'h';
                    avanza_o_retrocede = 'r';
                }
            }
            else
            {
                if (avanza_o_retrocede == 'a')
                {
                    direccion = 'v';
                    avanza_o_retrocede = 'r';
                }
                else
                {
                    direccion = 'v';
                    avanza_o_retrocede = 'a';
                }
            }
        }

        public void Avanza(int avanza)
        { //ABRE AVANZA

            int cuadros_avanza = avanza;
            char variable_a_mover;
            int i;
            int temporal;

            if ('h' == direccion)
            {
                variable_a_mover = 'x';
                temporal = x;
            }
            else
            {
                variable_a_mover = 'y';
                temporal = y;
            }

            if (avanza_o_retrocede == 'a')
            {
                for (i = variable_a_mover == 'x' ? x : y; ((avanza_o_retrocede == 'a') ? i <= (temporal + cuadros_avanza - 1) : i >= (temporal - cuadros_avanza + 1)); i++)
                {
                    if (variable_a_mover == 'x')
                    {
                        if (i <= Tamano_Ancho && i > 0)
                        { //ABRE EL IF DE FOR
                            A[i, y] = pluma1 == -1 ? 1 : 0;
                            x = avanza_o_retrocede == 'a' ? (x + 1) : (x - 1);
                        } //CIERRA EL IF DE FOR
                        else
                        {
                            if (i > Tamano_Ancho)
                            { // ABRE IF
                                A[Tamano_Ancho, y] = pluma1 == -1 ? 1 : 0;
                                x = Tamano_Ancho;
                            } //CIERRA IF
                            else
                            { // ABRE ELSE DE IF
                                A[1, y] = pluma1 == -1 ? 1 : 0;
                                x = 1;
                            } // CIERRA ELSE DE IF
                        } // CIERRA IF
                    } //CIERRA IF variable_a_mover
                    else
                    { //ABRE ELSE variable_a_mover
                        if (i <= Tamano_Alto && i > 0) //ABRE IF
                        {
                            A[x, i] = pluma1 == -1 ? 1 : 0;
                            //cout << "(" << x << "," << i << ")" << endl;
                            y = avanza_o_retrocede == 'a' ? (y + 1) : (y - 1);
                        } //CIERRA IF
                        else
                        { //ABRE ELSE
                            if (Tamano_Alto < i)
                            {
                                A[x, Tamano_Alto] = pluma1 == -1 ? 1 : 0;
                                y = Tamano_Alto;
                            }
                            else
                            { //ABRE ELSE INTERNO
                                A[x, 1] = pluma1 == -1 ? 1 : 0;
                                y = 1;
                            } //CIERRA ELSE INTERNO
                        } //CIERRA ELSE
                    } //CIERRA ELSE varia
                }
            }
            else
            {
                for (i = variable_a_mover == 'x' ? x : y; ((avanza_o_retrocede == 'a') ? i <= (temporal + cuadros_avanza - 1) : i >= (temporal - cuadros_avanza + 1)); i--)
                {
                    if (variable_a_mover == 'x')
                    {
                        if (i <= Tamano_Ancho && i > 0)
                        { //ABRE EL IF DE FOR
                            A[i, y] = pluma1 == -1 ? 1 : 0;
                            x = avanza_o_retrocede == 'a' ? (x + 1) : (x - 1);
                        } //CIERRA EL IF DE FOR
                        else
                        {
                            if (i > Tamano_Ancho)
                            { // ABRE IF
                                A[Tamano_Ancho, y] = pluma1 == -1 ? 1 : 0;
                                x = Tamano_Ancho;
                            } //CIERRA IF
                            else
                            { // ABRE ELSE DE IF
                                A[1, y] = pluma1 == -1 ? 1 : 0;
                                x = 1;
                            } // CIERRA ELSE DE IF
                        } // CIERRA IF
                    } //CIERRA IF variable_a_mover
                    else
                    { //ABRE ELSE variable_a_mover
                        if (i <= Tamano_Alto && i > 0) //ABRE IF
                        {
                            A[x, i] = pluma1 == -1 ? 1 : 0;
                            //cout << "(" << x << "," << i << ")" << endl;
                            y = avanza_o_retrocede == 'a' ? (y + 1) : (y - 1);
                        } //CIERRA IF
                        else
                        { //ABRE ELSE
                            if (Tamano_Alto < i)
                            {
                                A[x, Tamano_Alto] = pluma1 == -1 ? 1 : 0;
                                y = Tamano_Alto;
                            }
                            else
                            { //ABRE ELSE INTERNO
                                A[x, 1] = pluma1 == -1 ? 1 : 0;
                                y = 1;
                            } //CIERRA ELSE INTERNO
                        } //CIERRA ELSE
                    } //CIERRA ELSE varia
                }
            }
        }

        private string hj;

        public void Imprime()
        {
            int n, m;
            for (n = 1; n <= Tamano_Alto; n++)
            { // ABRE FOR
                for (m = 1; m <= Tamano_Ancho; m++)
                { //ABRE FOR ANIDADO
                    if (1 == A[m, n])
                        cad[m, n] = "*";
                    else
                        cad[m, n] = " ";
                } //CIERRA FOR ANIDADO
            } //CIERRA FOR
            hj = "";
            hj += Environment.NewLine;
            for (short i = 0; i < 20; i++)
            {
                for (short j = 0; j < 20; j++)
                {
                    hj += " " + cad[i, j];
                }
                hj += Environment.NewLine;
            }
        }

        public override string ToString()
        {
            return hj;
        }
    }
}
