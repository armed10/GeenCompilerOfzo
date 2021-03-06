﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeenCompiler.Tokens;

namespace GeenCompiler.Tokens {
    class RecognizeConditionToken : RecognizeTokenStrategy {
        public Token match(string name, Token lastToken) {
            Token token = null;
            if(name[0] == '<') {
                token = new Token();

                if(name[1] == '=') {
                    token.type = TokenType.SmallerOrEqualThan;
                } else {
                    token.type = TokenType.SmallerThan;
                }

            } else if(name[0] == '>') {
                token = new Token();
                if(name[1] == '=') {
                    token.type = TokenType.LargerOrEqualThan;
                } else {
                    token.type = TokenType.Largerthan;
                }

            } else if(name[0] == '=') {
                if(name[1] == '=') {
                    token = new Token();
                    token.type = TokenType.Equals;
                } 
            }
            if(token != null) {
                token.value = name.Substring(0, 2);
            }

            return token;
        }
    }
}
