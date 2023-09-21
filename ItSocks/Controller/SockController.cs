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
    /// <summary>
    /// responsible for sending and reciving from the UI layer
    /// </summary>
    public class SockController
    {

        public event EventHandler SockCalculated;

        SockCalculator createSock = new SockCalculator();

        
        public async void CreatePattern(int masks, int rows, int shoeSize, double cuffSizeInCentimeters, double lengthOShaft)
        {
            double startingNumberOfMasks = await createSock.CastOnMasksCalculator(masks, shoeSize);

            double roundsOnCuff = await createSock.RoundsOfCuffCalculator(rows, cuffSizeInCentimeters);

            double heelInCentimeter = await createSock.HeelInCentimetersCalculator(rows);

            double toeInCentimeter = await createSock.ToeInCentimeterCalculator(rows);

            double roundsOfSole = await createSock.RoundsOfSoelCalculator(rows);

            double masksInMiddelHeel = await createSock.MasksInMiddelHeelCalculator();
            double roundsOfShaft = await createSock.RoundsOfShaftCalculator(rows, lengthOShaft);

            //create a calculation for "roundsOfShaft" to replace the static input 2.0
            Sock sock = new Sock(roundsOnCuff, roundsOfShaft, heelInCentimeter, roundsOfSole,toeInCentimeter);

            SockCalculated?.Invoke(this, new SockEventArgs(sock));
        }

        public async void SockCreated(Sock sock)
        {

        }
    }
}
