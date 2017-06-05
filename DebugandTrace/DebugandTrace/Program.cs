
#define DEBUG // for debugging
//or
#define TRACE // for tracing

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DebugandTrace
{
    class Program
    {
        static void Main(string[] args)
        {
            // If you do not have DBMON.EXE, then to watch debug and trace messages,
            // make sure that the system will output debug and trace to the console.
            // Otherwise you cannot monitor Debug and Trace messages.
            // The DefaultTraceListener will output
            // to OutputDebugString of Windows operating systems.
            // We will talk about TraceListener classes later.
            // Debug.Listeners.Add(new TextWriterTraceListener(Console.Out));
            // Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            // Indent by one IndentSize times 1. Indent this time 6 x 1 = 6!

            //Debug.Listeners.Add(new TextWriterTraceListener(Console.Out));
            //Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));

            Debug.Indent();
            Trace.Indent();
            Debug.WriteLine("Debugged 1!");
            Trace.WriteLine("Traced 1!");

            bool bDebugTrace = false;

            // test for a boolean flag to output debug or trace.
            Debug.WriteLineIf(bDebugTrace, "Not Debugged 1!");
            Trace.WriteLineIf(bDebugTrace, "Not Traced 1!");
            bDebugTrace = true;

            // test for a boolean flag to output debug or trace.
            Debug.WriteLineIf(bDebugTrace, "Debugged 2!");
            Trace.WriteLineIf(bDebugTrace, "Traced 2!");

            // this is faster than WriteLineIf! So prefer the block below.
            if (bDebugTrace == true)
            {
                Debug.WriteLine("Debugged 3!");
                Trace.WriteLine("Traced 3!");
            }
            Console.Read();
        }
    }
}
