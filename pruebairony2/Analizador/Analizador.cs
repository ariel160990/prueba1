using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Irony.Ast;
using Irony.Parsing;

namespace PruebaIrony2
{
    class Analizador
    {
        private LanguageData lenguaje;
        private AccionesCalcu action;
        private Parser p;

        public Analizador() {
            lenguaje = new LanguageData(new Sintactic());
            action = new AccionesCalcu();
            p = new Parser(lenguaje);
        }        

        public Object parse(string str) {
                        
            ParseTree s_tree = p.Parse(str);
            if (s_tree.Root != null) {
                return action.do_action(s_tree.Root);                
            }
            return null;
        }
                
    }
}
