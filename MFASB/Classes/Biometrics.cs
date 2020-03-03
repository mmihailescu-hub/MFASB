using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MFASB.Classes
{
    class Biometrics
    {
        public void AddBiometricsCharacteristics(ComboBox cboBiometrics)
        {
            ArrayList alBiometricsCharacteristic = new ArrayList();
            alBiometricsCharacteristic.Add("Face Recognition");
            alBiometricsCharacteristic.Add("Holographic Signature");
            alBiometricsCharacteristic.Add("Handwritting");

            for (int i = 0; i < alBiometricsCharacteristic.Count; i++)
            {
                cboBiometrics.Items.Add(alBiometricsCharacteristic[i].ToString());
            }
        }
    }
}
