#ifndef FANTASMA_H
#define FANTASMA_H

#include <string>
#include <vector>
#include <list>
#include <iostream>
#include <assert.h>

#include "PersonagemDinamico.h"

class Fantasma : public PersonagemDinamico
{
public:
	void perseguir();

};
#endif
