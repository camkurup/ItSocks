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
        public async void CreatePattern(int masks, int rows, int shoeSize, double cuffSizeInCentimeters)
        {
            double startingNumberOfMasks = await createSock.CastOnMasksCalculator(masks, shoeSize);

            double roundsOnCuff = await createSock.RoundsOfCuffCalculator(rows, cuffSizeInCentimeters);

            double heelInCentimeter = await createSock.HeelInCentimetersCalculator(rows);

            double toeInCentimeter = await createSock.ToeInCentimeterCalculator(rows);

            double roundsOfSole = await createSock.RoundsOfSoleCalculator(rows);

            double masksInMiddelHeel = await createSock.MasksInMiddelHeel();

            //create a calculation for "roundsOfShaft" to replace the static input 2.0
            Sock sock = new Sock(roundsOnCuff, 2.0, heelInCentimeter, roundsOfSole,toeInCentimeter);

            SockCalculated?.Invoke(this, new SockEventArgs(sock));
        }
    }
}
