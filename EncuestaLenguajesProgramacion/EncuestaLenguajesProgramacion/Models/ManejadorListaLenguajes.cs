using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text.Json;

namespace EncuestaLenguajesProgramacion.Models
{
    public static class ManejadorListaLenguajes
    {

        public static String json = "[\"A# .NET\",\"A# (Axiom)\",\"A-0 System\",\"A+\",\"A++\",\"ABAP\",\"ABC\",\"ABC ALGOL\",\"ABLE\",\"ABSET\",\"ABSYS\",\"ACC\",\"Accent\",\"Ace DASL\",\"ACL2\",\"ACT-III\",\"Action!\",\"ActionScript\",\"Ada\",\"Adenine\",\"Agda\",\"Agilent VEE\",\"Agora\",\"AIMMS\",\"Alef\",\"ALF\",\"ALGOL 58\",\"ALGOL 60\",\"ALGOL 68\",\"ALGOL W\",\"Alice\",\"Alma-0\",\"AmbientTalk\",\"Amiga E\",\"AMOS\",\"AMPL\",\"APL\",\"App Inventor for Android's visual block language\",\"AppleScript\",\"Arc\",\"ARexx\",\"Argus\",\"AspectJ\",\"Assembly language\",\"ATS\",\"Ateji PX\",\"AutoHotkey\",\"Autocoder\",\"AutoIt\",\"AutoLISP / Visual LISP\",\"Averest\",\"AWK\",\"Axum\",\"B\",\"Babbage\",\"Bash\",\"BASIC\",\"bc\",\"BCPL\",\"BeanShell\",\"Batch (Windows/Dos)\",\"Bertrand\",\"BETA\",\"Bigwig\",\"Bistro\",\"BitC\",\"BLISS\",\"Blue\",\"Bon\",\"Boo\",\"Boomerang\",\"Bourne shell\",\"bash\",\"ksh\",\"BREW\",\"BPEL\",\"C\",\"C--\",\"C++\",\"C#\",\"C/AL\",\"Caché ObjectScript\",\"C Shell\",\"Caml\",\"Candle\",\"Cayenne\",\"CDuce\",\"Cecil\",\"Cel\",\"Cesil\",\"Ceylon\",\"CFEngine\",\"CFML\",\"Cg\",\"Ch\",\"Chapel\",\"CHAIN\",\"Charity\",\"Charm\",\"Chef\",\"CHILL\",\"CHIP-8\",\"chomski\",\"ChucK\",\"CICS\",\"Cilk\",\"CL\",\"Claire\",\"Clarion\",\"Clean\",\"Clipper\",\"CLIST\",\"Clojure\",\"CLU\",\"CMS-2\",\"COBOL\",\"Cobra\",\"CODE\",\"CoffeeScript\",\"Cola\",\"ColdC\",\"ColdFusion\",\"COMAL\",\"Combined Programming Language\",\"COMIT\",\"Common Intermediate Language\",\"Common Lisp\",\"COMPASS\",\"Component Pascal\",\"Constraint Handling Rules\",\"Converge\",\"Cool\",\"Coq\",\"Coral 66\",\"Corn\",\"CorVision\",\"COWSEL\",\"CPL\",\"csh\",\"CSP\",\"Csound\",\"CUDA\",\"Curl\",\"Curry\",\"Cyclone\",\"Cython\",\"D\",\"DASL\",\"DASL\",\"Dart\",\"DataFlex\",\"Datalog\",\"DATATRIEVE\",\"dBase\",\"dc\",\"DCL\",\"Deesel\",\"Delphi\",\"DinkC\",\"DIBOL\",\"Dog\",\"Draco\",\"DRAKON\",\"Dylan\",\"DYNAMO\",\"E\",\"E#\",\"Ease\",\"Easy PL/I\",\"Easy Programming Language\",\"EASYTRIEVE PLUS\",\"ECMAScript\",\"Edinburgh IMP\",\"EGL\",\"Eiffel\",\"ELAN\",\"Elixir\",\"Elm\",\"Emacs Lisp\",\"Emerald\",\"Epigram\",\"EPL\",\"Erlang\",\"es\",\"Escapade\",\"Escher\",\"ESPOL\",\"Esterel\",\"Etoys\",\"Euclid\",\"Euler\",\"Euphoria\",\"EusLisp Robot Programming Language\",\"CMS EXEC\",\"EXEC 2\",\"Executable UML\",\"F\",\"F#\",\"Factor\",\"Falcon\",\"Fancy\",\"Fantom\",\"FAUST\",\"Felix\",\"Ferite\",\"FFP\",\"Fjölnir\",\"FL\",\"Flavors\",\"Flex\",\"FLOW-MATIC\",\"FOCAL\",\"FOCUS\",\"FOIL\",\"FORMAC\",\"@Formula\",\"Forth\",\"Fortran\",\"Fortress\",\"FoxBase\",\"FoxPro\",\"FP\",\"FPr\",\"Franz Lisp\",\"Frege\",\"F-Script\",\"FSProg\",\"G\",\"Google Apps Script\",\"Game Maker Language\",\"GameMonkey Script\",\"GAMS\",\"GAP\",\"G-code\",\"Genie\",\"GDL\",\"Gibiane\",\"GJ\",\"GEORGE\",\"GLSL\",\"GNU E\",\"GM\",\"Go\",\"Go!\",\"GOAL\",\"Gödel\",\"Godiva\",\"GOM (Good Old Mad)\",\"Goo\",\"Gosu\",\"GOTRAN\",\"GPSS\",\"GraphTalk\",\"GRASS\",\"Groovy\",\"Hack (programming language)\",\"HAL/S\",\"Hamilton C shell\",\"Harbour\",\"Hartmann pipelines\",\"Haskell\",\"Haxe\",\"High Level Assembly\",\"HLSL\",\"Hop\",\"Hope\",\"Hugo\",\"Hume\",\"HyperTalk\",\"IBM Basic assembly language\",\"IBM HAScript\",\"IBM Informix-4GL\",\"IBM RPG\",\"ICI\",\"Icon\",\"Id\",\"IDL\",\"Idris\",\"IMP\",\"Inform\",\"Io\",\"Ioke\",\"IPL\",\"IPTSCRAE\",\"ISLISP\",\"ISPF\",\"ISWIM\",\"J\",\"J#\",\"J++\",\"JADE\",\"Jako\",\"JAL\",\"Janus\",\"JASS\",\"Java\",\"JavaScript\",\"JCL\",\"JEAN\",\"Join Java\",\"JOSS\",\"Joule\",\"JOVIAL\",\"Joy\",\"JScript\",\"JScript .NET\",\"JavaFX Script\",\"Julia\",\"Jython\",\"K\",\"Kaleidoscope\",\"Karel\",\"Karel++\",\"KEE\",\"Kixtart\",\"KIF\",\"Kojo\",\"Kotlin\",\"KRC\",\"KRL\",\"KUKA\",\"KRYPTON\",\"ksh\",\"L\",\"L# .NET\",\"LabVIEW\",\"Ladder\",\"Lagoona\",\"LANSA\",\"Lasso\",\"LaTeX\",\"Lava\",\"LC-3\",\"Leda\",\"Legoscript\",\"LIL\",\"LilyPond\",\"Limbo\",\"Limnor\",\"LINC\",\"Lingo\",\"Linoleum\",\"LIS\",\"LISA\",\"Lisaac\",\"Lisp\",\"Lite-C\",\"Lithe\",\"Little b\",\"Logo\",\"Logtalk\",\"LPC\",\"LSE\",\"LSL\",\"LiveCode\",\"LiveScript\",\"Lua\",\"Lucid\",\"Lustre\",\"LYaPAS\",\"Lynx\",\"M2001\",\"M4\",\"Machine code\",\"MAD\",\"MAD/I\",\"Magik\",\"Magma\",\"make\",\"Maple\",\"MAPPER\",\"MARK-IV\",\"Mary\",\"MASM Microsoft Assembly x86\",\"Mathematica\",\"MATLAB\",\"Maxima\",\"Macsyma\",\"Max\",\"MaxScript\",\"Maya (MEL)\",\"MDL\",\"Mercury\",\"Mesa\",\"Metacard\",\"Metafont\",\"MetaL\",\"Microcode\",\"MicroScript\",\"MIIS\",\"MillScript\",\"MIMIC\",\"Mirah\",\"Miranda\",\"MIVA Script\",\"ML\",\"Moby\",\"Model 204\",\"Modelica\",\"Modula\",\"Modula-2\",\"Modula-3\",\"Mohol\",\"MOO\",\"Mortran\",\"Mouse\",\"MPD\",\"CIL\",\"MSL\",\"MUMPS\",\"NASM\",\"NATURAL\",\"Napier88\",\"Neko\",\"Nemerle\",\"nesC\",\"NESL\",\"Net.Data\",\"NetLogo\",\"NetRexx\",\"NewLISP\",\"NEWP\",\"Newspeak\",\"NewtonScript\",\"NGL\",\"Nial\",\"Nice\",\"Nickle\",\"Nim\",\"NPL\",\"Not eXactly C\",\"Not Quite C\",\"NSIS\",\"Nu\",\"NWScript\",\"NXT-G\",\"o:XML\",\"Oak\",\"Oberon\",\"Obix\",\"OBJ2\",\"Object Lisp\",\"ObjectLOGO\",\"Object REXX\",\"Object Pascal\",\"Objective-C\",\"Objective-J\",\"Obliq\",\"Obol\",\"OCaml\",\"occam\",\"occam-π\",\"Octave\",\"OmniMark\",\"Onyx\",\"Opa\",\"Opal\",\"OpenCL\",\"OpenEdge ABL\",\"OPL\",\"OPS5\",\"OptimJ\",\"Orc\",\"ORCA/Modula-2\",\"Oriel\",\"Orwell\",\"Oxygene\",\"Oz\",\"P#\",\"ParaSail (programming language)\",\"PARI/GP\",\"Pascal\",\"Pawn\",\"PCASTL\",\"PCF\",\"PEARL\",\"PeopleCode\",\"Perl\",\"PDL\",\"PHP\",\"Phrogram\",\"Pico\",\"Picolisp\",\"Pict\",\"Pike\",\"PIKT\",\"PILOT\",\"Pipelines\",\"Pizza\",\"PL-11\",\"PL/0\",\"PL/B\",\"PL/C\",\"PL/I\",\"PL/M\",\"PL/P\",\"PL/SQL\",\"PL360\",\"PLANC\",\"Plankalkül\",\"Planner\",\"PLEX\",\"PLEXIL\",\"Plus\",\"POP-11\",\"PostScript\",\"PortablE\",\"Powerhouse\",\"PowerBuilder\",\"PowerShell\",\"PPL\",\"Processing\",\"Processing.js\",\"Prograph\",\"PROIV\",\"Prolog\",\"PROMAL\",\"Promela\",\"PROSE modeling language\",\"PROTEL\",\"ProvideX\",\"Pro*C\",\"Pure\",\"Python\",\"Q (equational programming language)\",\"Q (programming language from Kx Systems)\",\"Qalb\",\"QtScript\",\"QuakeC\",\"QPL\",\"R\",\"R++\",\"Racket\",\"RAPID\",\"Rapira\",\"Ratfiv\",\"Ratfor\",\"rc\",\"REBOL\",\"Red\",\"Redcode\",\"REFAL\",\"Reia\",\"Revolution\",\"rex\",\"REXX\",\"Rlab\",\"RobotC\",\"ROOP\",\"RPG\",\"RPL\",\"RSL\",\"RTL/2\",\"Ruby\",\"RuneScript\",\"Rust\",\"S\",\"S2\",\"S3\",\"S-Lang\",\"S-PLUS\",\"SA-C\",\"SabreTalk\",\"SAIL\",\"SALSA\",\"SAM76\",\"SAS\",\"SASL\",\"Sather\",\"Sawzall\",\"SBL\",\"Scala\",\"Scheme\",\"Scilab\",\"Scratch\",\"Script.NET\",\"Sed\",\"Seed7\",\"Self\",\"SenseTalk\",\"SequenceL\",\"SETL\",\"Shift Script\",\"SIMPOL\",\"SIGNAL\",\"SiMPLE\",\"SIMSCRIPT\",\"Simula\",\"Simulink\",\"SISAL\",\"SLIP\",\"SMALL\",\"Smalltalk\",\"Small Basic\",\"SML\",\"Snap!\",\"SNOBOL\",\"SPITBOL\",\"Snowball\",\"SOL\",\"Span\",\"SPARK\",\"Speedcode\",\"SPIN\",\"SP/k\",\"SPS\",\"Squeak\",\"Squirrel\",\"SR\",\"S/SL\",\"Stackless Python\",\"Starlogo\",\"Strand\",\"Stata\",\"Stateflow\",\"Subtext\",\"SuperCollider\",\"SuperTalk\",\"Swift (Apple programming language)\",\"Swift (parallel scripting language)\",\"SYMPL\",\"SyncCharts\",\"SystemVerilog\",\"T\",\"TACL\",\"TACPOL\",\"TADS\",\"TAL\",\"Tcl\",\"Tea\",\"TECO\",\"TELCOMP\",\"TeX\",\"TEX\",\"TIE\",\"Timber\",\"TMG\",\"Tom\",\"TOM\",\"Topspeed\",\"TPU\",\"Trac\",\"TTM\",\"T-SQL\",\"TTCN\",\"Turing\",\"TUTOR\",\"TXL\",\"TypeScript\",\"Turbo C++\",\"Ubercode\",\"UCSD Pascal\",\"Umple\",\"Unicon\",\"Uniface\",\"UNITY\",\"Unix shell\",\"UnrealScript\",\"Vala\",\"VBA\",\"VBScript\",\"Verilog\",\"VHDL\",\"Visual Basic\",\"Visual Basic .NET\",\"Visual DataFlex\",\"Visual DialogScript\",\"Visual Fortran\",\"Visual FoxPro\",\"Visual J++\",\"Visual J#\",\"Visual Objects\",\"Visual Prolog\",\"VSXu\",\"Vvvv\",\"WATFIV, WATFOR\",\"WebDNA\",\"WebQL\",\"Windows PowerShell\",\"Winbatch\",\"Wolfram\",\"Wyvern\",\"X++\",\"X#\",\"X10\",\"XBL\",\"XC\",\"XMOS architecture\",\"xHarbour\",\"XL\",\"Xojo\",\"XOTcl\",\"XPL\",\"XPL0\",\"XQuery\",\"XSB\",\"XSLT\",\"XPath\",\"Xtend\",\"Yorick\",\"YQL\",\"Z notation\",\"Zeno\",\"ZOPL\",\"ZPL\"]";
        public static List<LenguajeProgramacion> ListaLenguajes = null;
        public static double SumatoriaLenguajes = 0;

        public static void CrearLista()
        {
            List<String> raw = JsonSerializer.Deserialize<List<String>>(json);
            List<LenguajeProgramacion> lista = new List<LenguajeProgramacion>();
            
            for (int i = 0; i < raw.Count; i++)
            {
                lista.Add(new LenguajeProgramacion
                {
                    Id = i,
                    Nombre = raw[i],
                    ClasificacionPorcentual = 0,
                    DiferenciaPorcentual = 0,
                    Entradas = 0,
                    Posicion = 0
                });
            }

            ListaLenguajes = lista;
            //SumatoriaLenguajes = lista.Count();

        }

        private static void ActualizarLista()
        {
            double sumatoria = ListaLenguajes.Sum(a => a.Entradas);
            int length = ListaLenguajes.Count();
            for (int i = 0; i < length; i++)
            {
                ListaLenguajes[i].ClasificacionPorcentual = Convert.ToInt32((ListaLenguajes[i].Entradas / sumatoria) * 100);
            }
        }

        public static void AgregarEntrada(int lenguajePrimario, int lenguajeSecundario)
        {
            //var lp = ListaLenguajes.Find(l => l.Id == lenguajePrimario);
            //var ls = ListaLenguajes.Find(l => l.Id == lenguajeSecundario);
            //lp.Entradas += 1;
            //ls.Entradas += 0.5;
            //double sumatoria = ListaLenguajes.Sum(a => a.Entradas);
            ListaLenguajes.Find(l => l.Id == lenguajePrimario).Entradas += 1;
            ListaLenguajes.Find(l => l.Id == lenguajeSecundario).Entradas += 0.5;
            //lp.ClasificacionPorcentual += Convert.ToInt32((lp.Entradas / sumatoria) * 100); 
            //ls.ClasificacionPorcentual += Convert.ToInt32((ls.Entradas / sumatoria) * 100); 
            ActualizarLista();

        }
    }
}
