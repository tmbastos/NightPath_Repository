﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Nightpath.Models;

namespace Nightpath.DAL
{
    public class NightpathInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
           
            var Districts = new List<District>
            {
                new District {ID=1,DistrictName="Aveiro"},
                new District {ID=2,DistrictName="Beja"},
                new District {ID=3,DistrictName="Braga"},
                new District {ID=4,DistrictName="Bragança"},
                new District {ID=5,DistrictName="Castelo Branco"},
                new District {ID=6,DistrictName="Coimbra"},
                new District {ID=7,DistrictName="Évora"},
                new District {ID=8,DistrictName="Faro"},
                new District {ID=9,DistrictName="Guarda"},
                new District {ID=10,DistrictName="Leiria"},
                new District {ID=11,DistrictName="Lisboa"},
                new District {ID=12,DistrictName="Portalegre"},
                new District {ID=13,DistrictName="Porto"},
                new District {ID=14,DistrictName="Santarém"},
                new District {ID=15,DistrictName="Setúbal"},
                new District {ID=16,DistrictName="Viana do Castelo"},
                new District {ID=17,DistrictName="Vila Real"},
                new District {ID=18,DistrictName="Viseu"},
                new District {ID=31,DistrictName="Ilha da Madeira"},
                new District {ID=32,DistrictName="Ilha de Porto Santo"},
                new District {ID=41,DistrictName="Ilha de Santa Maria"},
                new District {ID=42,DistrictName="Ilha de São Miguel"},
                new District {ID=43,DistrictName="Ilha Terceira"},
                new District {ID=44,DistrictName="Ilha da Graciosa"},
                new District {ID=45,DistrictName="Ilha de São Jorge"},
                new District {ID=46,DistrictName="Ilha do Pico"},
                new District {ID=47,DistrictName="Ilha do Faial"},
                new District {ID=48,DistrictName="Ilha das Flores"},
                new District {ID=49,DistrictName="Ilha do Corvo"}

            };

            var Regions = new List<Region>
            {

                new Region {DistrictID=1,ID=1,RegionName="Águeda"},
                new Region {DistrictID=1,ID=2,RegionName="Albergaria-a-Velha"},
                new Region {DistrictID=1,ID=3,RegionName="Anadia"},
                new Region {DistrictID=1,ID=4,RegionName="Arouca"},
                new Region {DistrictID=1,ID=5,RegionName="Aveiro"},
                new Region {DistrictID=1,ID=6,RegionName="Castelo de Paiva"},
                new Region {DistrictID=1,ID=7,RegionName="Espinho"},
                new Region {DistrictID=1,ID=8,RegionName="Estarreja"},
                new Region {DistrictID=1,ID=9,RegionName="Santa Maria da Feira"},
                new Region {DistrictID=1,ID=10,RegionName="Ílhavo"},
                new Region {DistrictID=1,ID=11,RegionName="Mealhada"},
                new Region {DistrictID=1,ID=12,RegionName="Murtosa"},
                new Region {DistrictID=1,ID=13,RegionName="Oliveira de Azeméis"},
                new Region {DistrictID=1,ID=14,RegionName="Oliveira do Bairro"},
                new Region {DistrictID=1,ID=15,RegionName="Ovar"},
                new Region {DistrictID=1,ID=16,RegionName="São João da Madeira"},
                new Region {DistrictID=1,ID=17,RegionName="Sever do Vouga"},
                new Region {DistrictID=1,ID=18,RegionName="Vagos"},
                new Region {DistrictID=1,ID=19,RegionName="Vale de Cambra"},
                new Region {DistrictID=2,ID=6,RegionName="Castro Verde"},
                new Region {DistrictID=2,ID=7,RegionName="Cuba"},
                new Region {DistrictID=2,ID=8,RegionName="Ferreira do Alentejo"},
                new Region {DistrictID=2,ID=9,RegionName="Mértola"},
                new Region {DistrictID=2,ID=10,RegionName="Moura"},
                new Region {DistrictID=2,ID=11,RegionName="Odemira"},
                new Region {DistrictID=2,ID=12,RegionName="Ourique"},
                new Region {DistrictID=2,ID=13,RegionName="Serpa"},
                new Region {DistrictID=2,ID=14,RegionName="Vidigueira"},
                new Region {DistrictID=2,ID=1,RegionName="Aljustrel"},
                new Region {DistrictID=2,ID=2,RegionName="Almodôvar"},
                new Region {DistrictID=2,ID=3,RegionName="Alvito"},
                new Region {DistrictID=2,ID=4,RegionName="Barrancos"},
                new Region {DistrictID=2,ID=5,RegionName="Beja"},
                new Region {DistrictID=3,ID=6,RegionName="Esposende"},
                new Region {DistrictID=3,ID=7,RegionName="Fafe"},
                new Region {DistrictID=3,ID=8,RegionName="Guimarães"},
                new Region {DistrictID=3,ID=9,RegionName="Póvoa de Lanhoso"},
                new Region {DistrictID=3,ID=10,RegionName="Terras de Bouro"},
                new Region {DistrictID=3,ID=11,RegionName="Vieira do Minho"},
                new Region {DistrictID=3,ID=12,RegionName="Vila Nova de Famalicão"},
                new Region {DistrictID=3,ID=13,RegionName="Vila Verde"},
                new Region {DistrictID=3,ID=14,RegionName="Vizela"},
                new Region {DistrictID=3,ID=1,RegionName="Amares"},
                new Region {DistrictID=3,ID=2,RegionName="Barcelos"},
                new Region {DistrictID=3,ID=3,RegionName="Braga"},
                new Region {DistrictID=3,ID=4,RegionName="Cabeceiras de Basto"},
                new Region {DistrictID=3,ID=5,RegionName="Celorico de Basto"},
                new Region {DistrictID=4,ID=6,RegionName="Miranda do Douro"},
                new Region {DistrictID=4,ID=7,RegionName="Mirandela"},
                new Region {DistrictID=4,ID=8,RegionName="Mogadouro"},
                new Region {DistrictID=4,ID=9,RegionName="Torre de Moncorvo"},
                new Region {DistrictID=4,ID=10,RegionName="Vila Flor"},
                new Region {DistrictID=4,ID=11,RegionName="Vimioso"},
                new Region {DistrictID=4,ID=12,RegionName="Vinhais"},
                new Region {DistrictID=4,ID=1,RegionName="Alfândega da Fé"},
                new Region {DistrictID=4,ID=2,RegionName="Bragança"},
                new Region {DistrictID=4,ID=3,RegionName="Carrazeda de Ansiães"},
                new Region {DistrictID=4,ID=4,RegionName="Freixo de Espada à Cinta"},
                new Region {DistrictID=4,ID=5,RegionName="Macedo de Cavaleiros"},
                new Region {DistrictID=5,ID=6,RegionName="Oleiros"},
                new Region {DistrictID=5,ID=7,RegionName="Penamacor"},
                new Region {DistrictID=5,ID=8,RegionName="Proença-a-Nova"},
                new Region {DistrictID=5,ID=9,RegionName="Sertã"},
                new Region {DistrictID=5,ID=10,RegionName="Vila de Rei"},
                new Region {DistrictID=5,ID=11,RegionName="Vila Velha de Ródão"},
                new Region {DistrictID=5,ID=1,RegionName="Belmonte"},
                new Region {DistrictID=5,ID=2,RegionName="Castelo Branco"},
                new Region {DistrictID=5,ID=3,RegionName="Covilhã"},
                new Region {DistrictID=5,ID=4,RegionName="Fundão"},
                new Region {DistrictID=5,ID=5,RegionName="Idanha-a-Nova"},
                new Region {DistrictID=6,ID=6,RegionName="Góis"},
                new Region {DistrictID=6,ID=7,RegionName="Lousã"},
                new Region {DistrictID=6,ID=8,RegionName="Mira"},
                new Region {DistrictID=6,ID=9,RegionName="Miranda do Corvo"},
                new Region {DistrictID=6,ID=10,RegionName="Montemor-o-Velho"},
                new Region {DistrictID=6,ID=11,RegionName="Oliveira do Hospital"},
                new Region {DistrictID=6,ID=12,RegionName="Pampilhosa da Serra"},
                new Region {DistrictID=6,ID=13,RegionName="Penacova"},
                new Region {DistrictID=6,ID=14,RegionName="Penela"},
                new Region {DistrictID=6,ID=15,RegionName="Soure"},
                new Region {DistrictID=6,ID=16,RegionName="Tábua"},
                new Region {DistrictID=6,ID=17,RegionName="Vila Nova de Poiares"},
                new Region {DistrictID=6,ID=1,RegionName="Arganil"},
                new Region {DistrictID=6,ID=2,RegionName="Cantanhede"},
                new Region {DistrictID=6,ID=3,RegionName="Coimbra"},
                new Region {DistrictID=6,ID=4,RegionName="Condeixa-a-Nova"},
                new Region {DistrictID=6,ID=5,RegionName="Figueira da Foz"},
                new Region {DistrictID=7,ID=6,RegionName="Montemor-o-Novo"},
                new Region {DistrictID=7,ID=7,RegionName="Mora"},
                new Region {DistrictID=7,ID=8,RegionName="Mourão"},
                new Region {DistrictID=7,ID=9,RegionName="Portel"},
                new Region {DistrictID=7,ID=10,RegionName="Redondo"},
                new Region {DistrictID=7,ID=11,RegionName="Reguengos de Monsaraz"},
                new Region {DistrictID=7,ID=12,RegionName="Vendas Novas"},
                new Region {DistrictID=7,ID=13,RegionName="Viana do Alentejo"},
                new Region {DistrictID=7,ID=14,RegionName="Vila Viçosa"},
                new Region {DistrictID=7,ID=1,RegionName="Alandroal"},
                new Region {DistrictID=7,ID=2,RegionName="Arraiolos"},
                new Region {DistrictID=7,ID=3,RegionName="Borba"},
                new Region {DistrictID=7,ID=4,RegionName="Estremoz"},
                new Region {DistrictID=7,ID=5,RegionName="Évora"},
                new Region {DistrictID=8,ID=6,RegionName="Lagoa (Algarve)"},
                new Region {DistrictID=8,ID=7,RegionName="Lagos"},
                new Region {DistrictID=8,ID=8,RegionName="Loulé"},
                new Region {DistrictID=8,ID=9,RegionName="Monchique"},
                new Region {DistrictID=8,ID=10,RegionName="Olhão"},
                new Region {DistrictID=8,ID=11,RegionName="Portimão"},
                new Region {DistrictID=8,ID=12,RegionName="São Brás de Alportel"},
                new Region {DistrictID=8,ID=13,RegionName="Silves"},
                new Region {DistrictID=8,ID=14,RegionName="Tavira"},
                new Region {DistrictID=8,ID=15,RegionName="Vila do Bispo"},
                new Region {DistrictID=8,ID=16,RegionName="Vila Real de Santo António"},
                new Region {DistrictID=8,ID=1,RegionName="Albufeira"},
                new Region {DistrictID=8,ID=2,RegionName="Alcoutim"},
                new Region {DistrictID=8,ID=3,RegionName="Aljezur"},
                new Region {DistrictID=8,ID=4,RegionName="Castro Marim"},
                new Region {DistrictID=8,ID=5,RegionName="Faro"},
                new Region {DistrictID=9,ID=6,RegionName="Gouveia"},
                new Region {DistrictID=9,ID=7,RegionName="Guarda"},
                new Region {DistrictID=9,ID=8,RegionName="Manteigas"},
                new Region {DistrictID=9,ID=9,RegionName="Meda"},
                new Region {DistrictID=9,ID=10,RegionName="Pinhel"},
                new Region {DistrictID=9,ID=11,RegionName="Sabugal"},
                new Region {DistrictID=9,ID=12,RegionName="Seia"},
                new Region {DistrictID=9,ID=13,RegionName="Trancoso"},
                new Region {DistrictID=9,ID=14,RegionName="Vila Nova de Foz Côa"},
                new Region {DistrictID=9,ID=1,RegionName="Aguiar da Beira"},
                new Region {DistrictID=9,ID=2,RegionName="Almeida"},
                new Region {DistrictID=9,ID=3,RegionName="Celorico da Beira"},
                new Region {DistrictID=9,ID=4,RegionName="Figueira de Castelo Rodrigo"},
                new Region {DistrictID=9,ID=5,RegionName="Fornos de Algodres"},
                new Region {DistrictID=10,ID=6,RegionName="Caldas da Rainha"},
                new Region {DistrictID=10,ID=7,RegionName="Castanheira de Pêra"},
                new Region {DistrictID=10,ID=8,RegionName="Figueiró dos Vinhos"},
                new Region {DistrictID=10,ID=9,RegionName="Leiria"},
                new Region {DistrictID=10,ID=10,RegionName="Marinha Grande"},
                new Region {DistrictID=10,ID=11,RegionName="Nazaré"},
                new Region {DistrictID=10,ID=12,RegionName="Óbidos"},
                new Region {DistrictID=10,ID=13,RegionName="Pedrógão Grande"},
                new Region {DistrictID=10,ID=14,RegionName="Peniche"},
                new Region {DistrictID=10,ID=15,RegionName="Pombal"},
                new Region {DistrictID=10,ID=16,RegionName="Porto de Mós"},
                new Region {DistrictID=10,ID=1,RegionName="Alcobaça"},
                new Region {DistrictID=10,ID=2,RegionName="Alvaiázere"},
                new Region {DistrictID=10,ID=3,RegionName="Ansião"},
                new Region {DistrictID=10,ID=4,RegionName="Batalha"},
                new Region {DistrictID=10,ID=5,RegionName="Bombarral"},
                new Region {DistrictID=11,ID=6,RegionName="Lisboa"},
                new Region {DistrictID=11,ID=7,RegionName="Loures"},
                new Region {DistrictID=11,ID=8,RegionName="Lourinhã"},
                new Region {DistrictID=11,ID=9,RegionName="Mafra"},
                new Region {DistrictID=11,ID=10,RegionName="Oeiras"},
                new Region {DistrictID=11,ID=11,RegionName="Sintra"},
                new Region {DistrictID=11,ID=12,RegionName="Sobral de Monte Agraço"},
                new Region {DistrictID=11,ID=13,RegionName="Torres Vedras"},
                new Region {DistrictID=11,ID=14,RegionName="Vila Franca de Xira"},
                new Region {DistrictID=11,ID=15,RegionName="Amadora"},
                new Region {DistrictID=11,ID=16,RegionName="Odivelas"},
                new Region {DistrictID=11,ID=1,RegionName="Alenquer"},
                new Region {DistrictID=11,ID=2,RegionName="Arruda dos Vinhos"},
                new Region {DistrictID=11,ID=3,RegionName="Azambuja"},
                new Region {DistrictID=11,ID=4,RegionName="Cadaval"},
                new Region {DistrictID=11,ID=5,RegionName="Cascais"},
                new Region {DistrictID=12,ID=6,RegionName="Crato"},
                new Region {DistrictID=12,ID=7,RegionName="Elvas"},
                new Region {DistrictID=12,ID=8,RegionName="Fronteira"},
                new Region {DistrictID=12,ID=9,RegionName="Gavião"},
                new Region {DistrictID=12,ID=10,RegionName="Marvão"},
                new Region {DistrictID=12,ID=11,RegionName="Monforte"},
                new Region {DistrictID=12,ID=12,RegionName="Nisa"},
                new Region {DistrictID=12,ID=13,RegionName="Ponte de Sor"},
                new Region {DistrictID=12,ID=14,RegionName="Portalegre"},
                new Region {DistrictID=12,ID=15,RegionName="Sousel"},
                new Region {DistrictID=12,ID=1,RegionName="Alter do Chão"},
                new Region {DistrictID=12,ID=2,RegionName="Arronches"},
                new Region {DistrictID=12,ID=3,RegionName="Avis"},
                new Region {DistrictID=12,ID=4,RegionName="Campo Maior"},
                new Region {DistrictID=12,ID=5,RegionName="Castelo de Vide"},
                new Region {DistrictID=13,ID=6,RegionName="Maia"},
                new Region {DistrictID=13,ID=7,RegionName="Marco de Canaveses"},
                new Region {DistrictID=13,ID=8,RegionName="Matosinhos"},
                new Region {DistrictID=13,ID=9,RegionName="Paços de Ferreira"},
                new Region {DistrictID=13,ID=10,RegionName="Paredes"},
                new Region {DistrictID=13,ID=11,RegionName="Penafiel"},
                new Region {DistrictID=13,ID=12,RegionName="Porto"},
                new Region {DistrictID=13,ID=13,RegionName="Póvoa de Varzim"},
                new Region {DistrictID=13,ID=14,RegionName="Santo Tirso"},
                new Region {DistrictID=13,ID=15,RegionName="Valongo"},
                new Region {DistrictID=13,ID=16,RegionName="Vila do Conde"},
                new Region {DistrictID=13,ID=17,RegionName="Vila Nova de Gaia"},
                new Region {DistrictID=13,ID=18,RegionName="Trofa"},
                new Region {DistrictID=13,ID=1,RegionName="Amarante"},
                new Region {DistrictID=13,ID=2,RegionName="Baião"},
                new Region {DistrictID=13,ID=3,RegionName="Felgueiras"},
                new Region {DistrictID=13,ID=4,RegionName="Gondomar"},
                new Region {DistrictID=13,ID=5,RegionName="Lousada"},
                new Region {DistrictID=14,ID=6,RegionName="Cartaxo"},
                new Region {DistrictID=14,ID=7,RegionName="Chamusca"},
                new Region {DistrictID=14,ID=8,RegionName="Constância"},
                new Region {DistrictID=14,ID=9,RegionName="Coruche"},
                new Region {DistrictID=14,ID=10,RegionName="Entroncamento"},
                new Region {DistrictID=14,ID=11,RegionName="Ferreira do Zêzere"},
                new Region {DistrictID=14,ID=12,RegionName="Golegã"},
                new Region {DistrictID=14,ID=13,RegionName="Mação"},
                new Region {DistrictID=14,ID=14,RegionName="Rio Maior"},
                new Region {DistrictID=14,ID=15,RegionName="Salvaterra de Magos"},
                new Region {DistrictID=14,ID=16,RegionName="Santarém"},
                new Region {DistrictID=14,ID=17,RegionName="Sardoal"},
                new Region {DistrictID=14,ID=18,RegionName="Tomar"},
                new Region {DistrictID=14,ID=19,RegionName="Torres Novas"},
                new Region {DistrictID=14,ID=20,RegionName="Vila Nova da Barquinha"},
                new Region {DistrictID=14,ID=21,RegionName="Ourém"},
                new Region {DistrictID=14,ID=1,RegionName="Abrantes"},
                new Region {DistrictID=14,ID=2,RegionName="Alcanena"},
                new Region {DistrictID=14,ID=3,RegionName="Almeirim"},
                new Region {DistrictID=14,ID=4,RegionName="Alpiarça"},
                new Region {DistrictID=14,ID=5,RegionName="Benavente"},
                new Region {DistrictID=15,ID=6,RegionName="Moita"},
                new Region {DistrictID=15,ID=7,RegionName="Montijo"},
                new Region {DistrictID=15,ID=8,RegionName="Palmela"},
                new Region {DistrictID=15,ID=9,RegionName="Santiago do Cacém"},
                new Region {DistrictID=15,ID=10,RegionName="Seixal"},
                new Region {DistrictID=15,ID=11,RegionName="Sesimbra"},
                new Region {DistrictID=15,ID=12,RegionName="Setúbal"},
                new Region {DistrictID=15,ID=13,RegionName="Sines"},
                new Region {DistrictID=15,ID=1,RegionName="Alcácer do Sal"},
                new Region {DistrictID=15,ID=2,RegionName="Alcochete"},
                new Region {DistrictID=15,ID=3,RegionName="Almada"},
                new Region {DistrictID=15,ID=4,RegionName="Barreiro"},
                new Region {DistrictID=15,ID=5,RegionName="Grândola"},
                new Region {DistrictID=16,ID=6,RegionName="Ponte da Barca"},
                new Region {DistrictID=16,ID=7,RegionName="Ponte de Lima"},
                new Region {DistrictID=16,ID=8,RegionName="Valença"},
                new Region {DistrictID=16,ID=9,RegionName="Viana do Castelo"},
                new Region {DistrictID=16,ID=10,RegionName="Vila Nova de Cerveira"},
                new Region {DistrictID=16,ID=1,RegionName="Arcos de Valdevez"},
                new Region {DistrictID=16,ID=2,RegionName="Caminha"},
                new Region {DistrictID=16,ID=3,RegionName="Melgaço"},
                new Region {DistrictID=16,ID=4,RegionName="Monção"},
                new Region {DistrictID=16,ID=5,RegionName="Paredes de Coura"},
                new Region {DistrictID=17,ID=5,RegionName="Mondim de Basto"},
                new Region {DistrictID=17,ID=6,RegionName="Montalegre"},
                new Region {DistrictID=17,ID=7,RegionName="Murça"},
                new Region {DistrictID=17,ID=8,RegionName="Peso da Régua"},
                new Region {DistrictID=17,ID=9,RegionName="Ribeira de Pena"},
                new Region {DistrictID=17,ID=10,RegionName="Sabrosa"},
                new Region {DistrictID=17,ID=11,RegionName="Santa Marta de Penaguião"},
                new Region {DistrictID=17,ID=12,RegionName="Valpaços"},
                new Region {DistrictID=17,ID=13,RegionName="Vila Pouca de Aguiar"},
                new Region {DistrictID=17,ID=14,RegionName="Vila Real"},
                new Region {DistrictID=17,ID=1,RegionName="Alijó"},
                new Region {DistrictID=17,ID=2,RegionName="Boticas"},
                new Region {DistrictID=17,ID=3,RegionName="Chaves"},
                new Region {DistrictID=17,ID=4,RegionName="Mesão Frio"},
                new Region {DistrictID=18,ID=5,RegionName="Lamego"},
                new Region {DistrictID=18,ID=6,RegionName="Mangualde"},
                new Region {DistrictID=18,ID=7,RegionName="Moimenta da Beira"},
                new Region {DistrictID=18,ID=8,RegionName="Mortágua"},
                new Region {DistrictID=18,ID=9,RegionName="Nelas"},
                new Region {DistrictID=18,ID=10,RegionName="Oliveira de Frades"},
                new Region {DistrictID=18,ID=11,RegionName="Penalva do Castelo"},
                new Region {DistrictID=18,ID=12,RegionName="Penedono"},
                new Region {DistrictID=18,ID=13,RegionName="Resende"},
                new Region {DistrictID=18,ID=14,RegionName="Santa Comba Dão"},
                new Region {DistrictID=18,ID=15,RegionName="São João da Pesqueira"},
                new Region {DistrictID=18,ID=16,RegionName="São Pedro do Sul"},
                new Region {DistrictID=18,ID=17,RegionName="Sátão"},
                new Region {DistrictID=18,ID=18,RegionName="Sernancelhe"},
                new Region {DistrictID=18,ID=19,RegionName="Tabuaço"},
                new Region {DistrictID=18,ID=20,RegionName="Tarouca"},
                new Region {DistrictID=18,ID=21,RegionName="Tondela"},
                new Region {DistrictID=18,ID=22,RegionName="Vila Nova de Paiva"},
                new Region {DistrictID=18,ID=23,RegionName="Viseu"},
                new Region {DistrictID=18,ID=24,RegionName="Vouzela"},
                new Region {DistrictID=18,ID=1,RegionName="Armamar"},
                new Region {DistrictID=18,ID=2,RegionName="Carregal do Sal"},
                new Region {DistrictID=18,ID=3,RegionName="Castro Daire"},
                new Region {DistrictID=18,ID=4,RegionName="Cinfães"},
                new Region {DistrictID=31,ID=5,RegionName="Ponta do Sol"},
                new Region {DistrictID=31,ID=6,RegionName="Porto Moniz"},
                new Region {DistrictID=31,ID=7,RegionName="Ribeira Brava"},
                new Region {DistrictID=31,ID=8,RegionName="Santa Cruz"},
                new Region {DistrictID=31,ID=9,RegionName="Santana"},
                new Region {DistrictID=31,ID=10,RegionName="São Vicente"},
                new Region {DistrictID=31,ID=1,RegionName="Calheta (Madeira)"},
                new Region {DistrictID=31,ID=2,RegionName="Câmara de Lobos"},
                new Region {DistrictID=31,ID=3,RegionName="Funchal"},
                new Region {DistrictID=31,ID=4,RegionName="Machico"},
                new Region {DistrictID=32,ID=1,RegionName="Porto Santo"},
                new Region {DistrictID=41,ID=1,RegionName="Vila do Porto"},
                new Region {DistrictID=42,ID=5,RegionName="Ribeira Grande"},
                new Region {DistrictID=42,ID=6,RegionName="Vila Franca do Campo"},
                new Region {DistrictID=42,ID=1,RegionName="Lagoa (São Miguel)"},
                new Region {DistrictID=42,ID=2,RegionName="Nordeste"},
                new Region {DistrictID=42,ID=3,RegionName="Ponta Delgada"},
                new Region {DistrictID=42,ID=4,RegionName="Povoação"},
                new Region {DistrictID=43,ID=1,RegionName="Angra do Heroísmo"},
                new Region {DistrictID=43,ID=2,RegionName="Praia da Vitória"},
                new Region {DistrictID=44,ID=1,RegionName="Santa Cruz da Graciosa"},
                new Region {DistrictID=45,ID=1,RegionName="Calheta (São Jorge)"},
                new Region {DistrictID=45,ID=2,RegionName="Velas"},
                new Region {DistrictID=46,ID=1,RegionName="Lajes do Pico"},
                new Region {DistrictID=46,ID=2,RegionName="Madalena"},
                new Region {DistrictID=46,ID=3,RegionName="São Roque do Pico"},
                new Region {DistrictID=47,ID=1,RegionName="Horta"},
                new Region {DistrictID=48,ID=1,RegionName="Lajes das Flores"},
                new Region {DistrictID=48,ID=2,RegionName="Santa Cruz das Flores"},
                new Region {DistrictID=49,ID=1,RegionName="Corvo"},


            };

        }
    }
}