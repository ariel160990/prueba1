using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Irony.Parsing;
using Irony.Ast;

namespace PruebaIrony2
{
    public class Sintactic: Grammar
    {
        public Sintactic() { 
            //terminales
            
            var number = TerminalFactory.CreateCSharpNumber("number");
            CommentTerminal comm = new CommentTerminal("comm","\n","\r");

            base.NonGrammarTerminals.Add(comm);
            
            IdentifierTerminal id = new IdentifierTerminal("id");

            //no terminales

            NonTerminal s0 = new NonTerminal("s0"),
                        e = new NonTerminal("e"),
                        t = new NonTerminal("t"),
                        f = new NonTerminal("f");

            s0.Rule = e;

            e.Rule = e + "+"+t
                |e +"-"+ t
                |t;
            t.Rule = t + "*" + f
                | t + "/" + f
                |f;

            f.Rule = ToTerm("(") + e + ")"
                | number;

            this.Root = s0;
            
            MarkPunctuation("(",")");
        }
    }
}
