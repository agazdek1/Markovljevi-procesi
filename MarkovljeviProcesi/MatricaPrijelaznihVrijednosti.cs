using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkovljeviProcesi
{
    class MatricaPrijelaznihVrijednosti
    {
        private double elementAA;
        private double elementAB;
        private double elementAC;

        private double elementBA;
        private double elementBB;
        private double elementBC;

        private double elementCA;
        private double elementCB;
        private double elementCC;

        public MatricaPrijelaznihVrijednosti(double elementAA, double elementAB, double elementAC, double elementBA, double elementBB, double elementBC, double elementCA, double elementCB, double elementCC)
        {
            this.elementAA = elementAA;
            this.elementAB = elementAB;
            this.elementAC = elementAC;
            this.elementBA = elementBA;
            this.elementBB = elementBB;
            this.elementBC = elementBC;
            this.elementCA = elementCA;
            this.elementCB = elementCB;
            this.elementCC = elementCC;
        }

        public double ElementAA { get => elementAA; set => elementAA = value; }
        public double ElementAB { get => elementAB; set => elementAB = value; }
        public double ElementAC { get => elementAC; set => elementAC = value; }
        public double ElementBA { get => elementBA; set => elementBA = value; }
        public double ElementBB { get => elementBB; set => elementBB = value; }
        public double ElementBC { get => elementBC; set => elementBC = value; }
        public double ElementCA { get => elementCA; set => elementCA = value; }
        public double ElementCB { get => elementCB; set => elementCB = value; }
        public double ElementCC { get => elementCC; set => elementCC = value; }
    }
}
