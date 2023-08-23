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
        public async void CreatePattern(int masks, int rows, int shoeSize, double cuffSizeInCentimeters)
        {
            double startingNumberOfMasks = await createSock.CastOnMasksCalculator(masks, shoeSize);

            double roundsOnCuff = await createSock.RoundsOfCuffCalculator(rows, cuffSizeInCentimeters);

            double heelInCentimeter = await createSock.HeelInCentimetersCalculator(rows);

            double toeInCentimeter = await createSock.ToeInCentimeterCalculator(rows);

            double roundsOfSole = await createSock.RoundsOfSoleCalculator(rows);

            double masksInMiddelHeel = await createSock.MasksInMiddelHeel();

           
            Debug.WriteLine("Antal masker der skal slåes op " + startingNumberOfMasks);
            Debug.WriteLine("Antal omgange der skal strikkes " + roundsOnCuff);
            Debug.WriteLine("Hælen skal være " + heelInCentimeter + " cm.");
            Debug.WriteLine("Tå i Centimeter: " + toeInCentimeter);
            Debug.WriteLine("omgange sål i centimeter: " + roundsOfSole);
            Debug.WriteLine("TEST: " + masksInMiddelHeel);

            //create a calculation for "roundsOfShaft"
            Sock sock = new Sock(roundsOnCuff, 2.0, heelInCentimeter, roundsOfSole,toeInCentimeter);

            SockCalculated?.Invoke(this, new SockEventArgs(sock));
        }
    }
}
