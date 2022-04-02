using System;
using System.Collections.Generic;
using System.Text;
using EasyStatistics; // using created ddl file

namespace Lab9_10
{
    class Skewness : Statistics // inheritng from ddl
    {
        private float _pearsonModeSkewness;
        private float _pearsonMedianSkewness; // member variables

        public float PearsonModeSkewness
        {
            get { return _pearsonModeSkewness; }
            private set { _pearsonModeSkewness = value; }
        }

        public float PearsonMedianSkewness
        {
            get { return _pearsonMedianSkewness; }
            private set { _pearsonMedianSkewness = value; }
        }// class properties

        public Skewness(float[] pData) : base(pData)
        {
            if (pData == null)
            {
                throw new ArgumentNullException(nameof(pData));
            }
            else
            {
                // Compute Pearson Mode Skewness 
                ComputePearsonModeSkewness(pData);

                // Compute Pearson Median Skewness 
                ComputePearsonMedianSkewness(pData);
            }
        }

        private void ComputePearsonMedianSkewness(float[] pData)
        {
            PearsonModeSkewness = (Mean - Mode) / StandardDeviation;
        }

        private void ComputePearsonModeSkewness(float[] pData)
        {
            PearsonMedianSkewness = (3 * (Mean - Median)) / StandardDeviation;
        }// clalcualting pearson statistics using variables from the ddl file 


    }
}
