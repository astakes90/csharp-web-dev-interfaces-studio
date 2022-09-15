using System;
using System.Collections.Generic;

namespace SpinningDiscs
{
    public class CD : BaseDisc, IOpticalDisc
    {
        public List<string> TrackNames { get; set; }

        public CD(string name, string discType, List<string> trackNames) : base(name, discType)
        {
            TrackNames = trackNames;
        }
        // TODO: Implement your custom interface.

        public void SpinDisc()
        {
            Console.WriteLine("A CD spins at a rate of 200 - 500 rpm.");
        }

        public void StoreInfo()
        {
            Console.WriteLine("Info has been stored.");
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name} \n Disc Type: {DiscType} \n Track Names: {TrackNames} \n Storage Capacity: {IOpticalDisc.StorageCapacity}");
        }

    }
}
