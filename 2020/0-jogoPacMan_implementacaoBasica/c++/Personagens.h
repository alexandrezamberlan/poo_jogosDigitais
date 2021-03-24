#ifndef PERSONAGENS_H
#define PERSONAGENS_H

#include <string>
#include <vector>
#include <list>
#include <iostream>
#include <assert.h>

#include "String.h"

class Personagens
{
private:
	String cor;

	int energia;

	int tamanho;

	int posicaoX;

	int posicaoY;


public:
	void irParaEsquerda();

	void irParaDireita();

};
#endif
