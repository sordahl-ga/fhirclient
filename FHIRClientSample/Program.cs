using System;
using Hl7.Fhir.Model;
namespace FHIRClientSample
{
    class Program
    {
        static void Main(string[] args)
        {
            FHIRSupport.FHIRClient client = new FHIRSupport.FHIRClient("<serverurl>", "<tenent>", "<clientid>", "<clientsecret>");
            Patient p  = (Patient) client.LoadResource("Patient/<pat_id>");
        }   
    }
}
