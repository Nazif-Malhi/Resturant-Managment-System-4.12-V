using MessagingToolkit.QRCode.Codec;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spinzer_Managment_System__4._12_V_.ExternalResoursces.QRCode
{
    public class QR_Code
    {
        public Bitmap encode(string element) {
            QRCodeEncoder encoder = new QRCodeEncoder();
            encoder.QRCodeScale = 8;
            Bitmap bitmap = encoder.Encode(element);
            Bitmap resize = new Bitmap(bitmap, new Size(78, 78));
            return resize;
        }
    }
}
