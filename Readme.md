# Marques Atlètiques

L'objectiu d'aquesta aplicació es poder generar llistes de les marques aconseguides per els atletes de
qualsevol categoria en qualsevol moment de l'historia del club.

Per aconseguir-ho, l'aplicació permet entrar les dades i fen servir les regles de la federació d'atletisme 
espanyol i català, s'enumeren les condicions de l'entrada de dades:

## Prova atlètica
- Es mesura en **temps**, **distancia** o **punts**.
- Pot ser **masculina**, **femenina** o **mixta** (amb integrants masculins i femenins)
- Pot incorporar **1**, **3** o **4** atletes
- Pot realitzar-se en **pista coberta** o al **aire lliure**.

## Marca atlètica
- Si la prova conté més d'un atleta, l'any de naixement del atleta mes jove es farà servir com a referencia.
- La marca s'asignará a una **categoría**, **temporada** i **lloc**.
- Es permet opcionalment incorporar **comentaris**: _'record espanya'_ _'record comarcal'_, etc
- Es permet opcionalment incorporar **comprobant**: _'diari la Vanguardia 18/4/2010. pag.33'_

## Mesura de la prova
- El **temps** tindrá el format: | 3h 22' 44" 325 | => valor d'hora, minuts, segons i centècimes de segon. 
S'admet la no inclusió dels valors no necesaris exemple: 1h 3" - 2' 4" - 59" 254 - 1h 0" 325
(excepció: per definir les centesimes de segon, es té que definir els segons - encara que siguin zero segons)
- La **distancia** tindrá el format: | 12.052 mts | => valor numeric amb 3 decimals
- Els **punts** tindrá el format: | 425 punts | => valor numeric sense decimals

## Temporada de la prova
- La temporada comença cada 1 de novembre, aixi que quan ens referim a una temporada
es el periode entre l'u de novembre i el trenta-u d'octubre del any següent.

## Categoría de la prova
- La categoria es calcula sobre l'any de la prova i l'any de naixemement del atleta mes jove que ha fet la prova.
- Sobre la edat resultant es fa servir la seggüent taula

| **Edats** |  **Categoria**|
|---|------|
| 35-... | Vetera     |        
| 22-34  | Senior     |        
| 20-21  | Promesa    | sub-23 |
| 18-19  | Junior     | sub-20 |
| 16-17  | Juvenil    | sub-18 |
| 14-15  | Cadet      | sub-16 |
| 12-13  | Infantil   | sub-14 |
| 10-11  | Aleví      | sub-12 |
| 8-9    | Benjamí    | sub-10 |
| 0-7    | PreBenjamí |        

## Filtre a la llista del ranking

Sexe - Pista - Categoria - Incluir categories inferiors - Prova - Quantitat de marques (per defecte 50)


#### Exemples de marques

| **Pista** | **Prova** | **Atletes** | **Any naixement** | **Sexe** | **Data** | **Marca** | **Categoria** | **Temporada** | **Lloc** | **Comentaris** | **Comprobant** |
|---|---|---|---:|---|---|---:|---|---|---|---|---|
| Coberta | 60 mt ll. | SANTAFE PAGA, ELOI | 2001 | Masculí | 11/02/2017 | 7" 26 | Juvenil | 2016/2017 | Sabadell || FCA |
| Coberta | Triple salt | SALMERON HUCKE, OLIVIA | 2003 | Femení | 08/01/2017 | 9.97 mts | Cadet | 2016/2017 |  Sabadell || FCA |
| Coberta | Hexathlon | SEGURA GOMEZ, ADRIA | 2002 | Masculí | 21/02/2016 | 2506 pts | Cadet | 2015/2016 | Sabadell || FCA |
| Coberta | 4x200m | N.PEREZ-S.PLA-E.MOLIST-D.SERRANO | 2001 | Masculí | 13/12/2015 | 2' 18" 45 | Cadet | 2015/2016 | Sabadell || FCA |
| Aire lliure | 600m | VALDES GRIS, SERGI | 2001 | Masculí | 03/04/2016 | 1' 36" 79 | Cadet | 2015/2016 | El Prat de Llobregat || FCA |
| Aire lliure | Disco (800g) | CASAS CAUBA, MARINA | 2001 | Femení | 19/03/2016 | 18.16 mts | Infantil | 2015/2016 | Manresa || FCA |
| Aire lliure | 3x600m | T.ESPEJO-L.BENITEZ-E.PUJOL | 2000 | Femení |30/04/2016 | 7' 13" 4 | Juvenil | 2015/2016 | Mataró || FCA |
| Aire lliure | Pentathlon | ALVARO DURAN, MARIA | 2000 | Femení | 28/11/2015 | 1455 pts | Cadet | 2015/2016 | Gavà || FCA |




