
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;
using MathNet.Numerics.Statistics.Mcmc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkovljeviProcesi
{
    class Struktura
    {
        private double elementA;
        private double elementB;
        private double elementC;

        public Struktura(double elementA, double elementB, double elementC)
        {
            this.elementA = elementA;
            this.elementB = elementB;
            this.elementC = elementC;
        }

        public double ElementA { get => elementA; set => elementA = value; }
        public double ElementB { get => elementB; set => elementB = value; }
        public double ElementC { get => elementC; set => elementC = value; }

        public static Struktura IzracunajStrukturuZaSljedeceRazdoblje(MatricaPrijelaznihVrijednosti matrica, Struktura struktura)
        {
            var matricaPrijelaznihVrijednosti = DenseMatrix.OfArray(new double[,] { { matrica.ElementAA, matrica.ElementAB, matrica.ElementAC }, { matrica.ElementBA, matrica.ElementBB, matrica.ElementBC }, { matrica.ElementCA, matrica.ElementCB, matrica.ElementCC } });
            var strukturaUdjela = DenseMatrix.OfArray(new double[,] { { struktura.elementA }, { struktura.elementB }, { struktura.elementC } });
            var strukturaUSljedecemRazdoblju = matricaPrijelaznihVrijednosti*strukturaUdjela;

            Struktura strukturaSljedecegRazdoblja = new Struktura(Math.Round(strukturaUSljedecemRazdoblju[0, 0], 3), Math.Round(strukturaUSljedecemRazdoblju[1, 0], 3), Math.Round(strukturaUSljedecemRazdoblju[2, 0], 3));
            return strukturaSljedecegRazdoblja;

        }
        public static Struktura IzracunajStabilnoStanje(MatricaPrijelaznihVrijednosti matrica)
        {

            var matricaPrijelaznihVrijednosti = DenseMatrix.OfArray(new double[,] { { Math.Round(matrica.ElementAA - 1, 3), matrica.ElementAB, matrica.ElementAC }, { matrica.ElementBA, Math.Round(matrica.ElementBB - 1, 3), matrica.ElementBC }, { 1, 1, 1 } }) ;
            var strukturaUdjela = DenseMatrix.OfArray(new double[,] { { 0 }, { 0}, {1} });
            var strukturaUSljedecemRazdoblju = matricaPrijelaznihVrijednosti.Solve(strukturaUdjela);

            Struktura strukturaSljedecegRazdoblja = new Struktura(Math.Round(strukturaUSljedecemRazdoblju[0, 0], 3), Math.Round(strukturaUSljedecemRazdoblju[1, 0], 3), Math.Round(strukturaUSljedecemRazdoblju[2, 0], 3));
            return strukturaSljedecegRazdoblja;

        }

    }
}
