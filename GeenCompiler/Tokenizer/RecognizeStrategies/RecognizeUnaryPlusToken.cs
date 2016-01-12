﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeenCompiler.Tokens {
    class RecognizeUnaryPlusToken : RecognizeTokenStrategy{

        public Token match(string name, Token lastToken) {
            Token token = null;
            if(name.StartsWith("++")){
                if(lastToken != null && //lastToken could be NULL!
                (lastToken.type == TokenType.Variable || lastToken.type == TokenType.Number)) { //Binary operator condition
                    token = new Token();
                    token.type = TokenType.AddOne;
                    token.value = "++";
                }
            }
            return token;
        }
    }
}