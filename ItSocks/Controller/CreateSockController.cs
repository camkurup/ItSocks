using ItSocks.Data;
using ItSocks.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItSocks.Controller
{
    public class CreateSockController
    {
        public event EventHandler SockCalculated;
        CreateSock createSock = new CreateSock();
        CreatePDF createPDF = new CreatePDF();
        public void CreatePattern(int masks, int rows, int shoeSize, double cuffSizeInCentimeters)
        {
            double startingNumberOfMasks = createSock.CastOnMasksCalculator(masks, shoeSize);
            Debug.WriteLine("Antal masker der skal slåes op " + startingNumberOfMasks);

            double rounds = createSock.RoundsOfCuffCalculator(rows, cuffSizeInCentimeters);
            Debug.WriteLine("Antal omgange der skal strikkes " + rounds);

            double heelInCentimeter = createSock.HeelInCentimetersCalculator(rows);
            Debug.WriteLine("Hælen skal være " +  heelInCentimeter + " cm.");

            double toeInCentimeter = createSock.ToeInCentimeterCalculator(rows);
            Debug.WriteLine("Tå i Centimeter: " + toeInCentimeter);

            double roundsOfSole = createSock.RoundsOfSoleCalculator(rows);
            Debug.WriteLine("omgange sål i centimeter: " + roundsOfSole);

            double masksInMiddelHeel = createSock.MasksInMiddelHeel();
            Debug.WriteLine("TEST: " + masksInMiddelHeel);

            Sock sock = new Sock(cuffSizeInCentimeters);

            SockCalculated?.Invoke(this, new SockEventArgs(sock));
        }

       
        public void PreviewPattern()
        {

        }
    }
}
