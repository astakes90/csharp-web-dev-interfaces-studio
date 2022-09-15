using System;
using System.Collections.Generic;

namespace SpinningDiscs
{
    public class DVD : BaseDisc, IOpticalDisc
    {
        public string MovieSynopsis { get; set; }

        public DVD(string name, string discType, string movieSynopsis) : base(name, discType)
        {
            MovieSynopsis = movieSynopsis;
        }

        public void SpinDisc()
        {
            Console.WriteLine("A DVD spins at a rate of 570 - 1600 rpm.");
        }

        public void StoreInfo()
        {
            Console.WriteLine("Info has been stored.");
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name} \n Disc Type: {DiscType} \n Movie Synopsis: {MovieSynopsis} \n Storage Capacity: {IOpticalDisc.StorageCapacity}");
        }

    }
}
