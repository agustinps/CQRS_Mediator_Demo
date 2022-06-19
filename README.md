# Patrones CQRS y Mediator con MediatR

## CQRS_Mediator_Demo

CQRS .- Segregacion de responsabilidad de consulta de comando. Este patrón nos hace dividir las operaciones CRUD en dos modelos:

  1. consultas (R)   
  2. comandos (CUD)

El patrón mediador por su parte, simplemente encapsula como interactuan los objetos entre sí, en lugar de que tegan una dependencia directa unos de otros interactuan con un mediador y permite un acoplamiento flexible.

MediatR nos ayuda a resolver estas dos cuestiones de una forma muy sencilla y con este proyecto se pretende hacer una demo de ello.
