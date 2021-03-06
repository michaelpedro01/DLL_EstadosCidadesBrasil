﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstadosCidadesBrasil
{
    public abstract class Cidades
    {
        //Vetor que armazenará as cidades dos estados do Brasil.
        private string[] citiesOfBrazil;

        /// <summary>
        /// Retorna em um componente ComboBox a lista de cidades pertencentes ao estado do Acre.
        /// </summary>
        /// <param name="cb">Componente ComboBox que receberá o retorno das cidades.</param>
        public virtual ComboBox Acre(ComboBox cb)
        {
            citiesOfBrazil = new string[]
            {
                "Acrelandia", "Assis Brasil",

                "Brasileia", "Bujari",

                "Capixaba", "Cruzeiro do Sul",

                "Epitaciolandia",

                "Feijo",

                "Jordao",

                "Mancio Lima", "Manoel Urbano", "Marechal Thaumaturgo",

                "Placido de Castro", "Porto Acre", "Porto Walter",

                "Rio Branco", "Rodrigues Alves",

                "Santa Rosa do Purus", "Sena Madureira", "Senador Guiomard",

                "Tarauaca",

                "Xapuri"
            };

            cb.Items.AddRange(citiesOfBrazil);

            return cb;
        }

        /// <summary>
        /// Retorna em um componente ComboBox a lista de cidades pertencentes ao estado de Alagoas.
        /// </summary>
        /// <param name="cb">Componente ComboBox que receberá o retorno das cidades.</param>
        public virtual ComboBox Alagoas(ComboBox cb)
        {
            citiesOfBrazil = new string[]
            {
                "Água Branca", "Anadia", "Arapiraca", "Atalaia",

                "Barra de Santo Antônio", "Barra de São Miguel", "Batalha", "Belém",
                "Belo Monte", "Boca da Mata", "Branquinha",

                "Cacimbinhas", "Cajueiro", "Campestre", "Campo Alegre", "Campo Grande",
                "Canapi", "Capela", "Carneiros", "Chã Preta", "Coité do Nóia", "Colônia Leopoldina",
                "Coqueiro Seco", "Coruripe", "Craíbas",

                "Delmiro Gouveia", "Dois Riachos",

                "Estrela de Alagoas",

                "Feira Grande", "Feliz Deserto", "Flexeiras",

                "Girau do Ponciano",

                "Ibateguara", "Igaci", "Igreja Nova", "Inhapi",

                "Jacaré dos Homens", "Jacuípe", "Japaratinga", "Jaramataia",
                "Jequiá da Praia", "Joaquim Gomes", "Jundiá", "Junqueiro",

                "Lagoa da Canoa", "Limoeiro de Anadia",

                "Maceió", "Major Isidoro", "Mar Vermelho", "Maragogi", "Maravilha", "Marechal Deodoro",
                "Maribondo", "Mata Grande", "Matriz de Camaragibe", "Messias", "Minador do Negrão",
                "Monteirópolis", "Murici",

                "Novo Lino",

                "Olho dÁgua das Flores", "Olho dÁgua do Casado",
                "Olho dÁgua Grande", "Olivença", "Ouro Branco",

                "Palestina", "Palmeira dos Índios", "Pão de Açúcar", "Pariconha", "Paripueira",
                "Passo de Camaragibe", "Paulo Jacinto", "Penedo", "Piaçabuçu", "Pilar",
                "Pindoba", "Piranhas", "Poço das Trincheiras", "Porto Calvo", "Porto de Pedras",
                "Porto Real do Colégio",

                "Quebrangulo",

                "Rio Largo", "Roteiro",

                "Santa Luzia do Norte", "Santana do Ipanema", "Santana do Mundaú", "São Brás",
                "São José da Laje", "São José da Tapera", "São Luís do Quitunde", "São Miguel dos Campos",
                "São Miguel dos Milagres", "São Sebastião", "Satuba", "Senador Rui Palmeira",

                "Tanque dArca", "Taquarana", "Teotônio Vilela", "Traipu",

                "União dos Palmares",

                "Viçosa"
            };

            cb.Items.AddRange(citiesOfBrazil);

            return cb;
        }

        /// <summary>
        /// Retorna em um componente ComboBox a lista de cidades pertencentes ao estado do Amapá.
        /// </summary>
        /// <param name="cb">Componente ComboBox que receberá o retorno das cidades.</param>
        public virtual ComboBox Amapá(ComboBox cb)
        {
            citiesOfBrazil = new string[]
            {
                "Amapá",

                "Calçoene", "Cutias",

                "Ferreira Gomes",

                "Itaubal",

                "Laranjal do Jari",

                "Macapá", "Mazagão",

                "Oiapoque",

                "Pedra Branca do Amapari", "Porto Grande", "Pracuúba",

                "Santana", "Serra do Navio",

                "Tartarugalzinho",

                "Vitória do Jari"
            };

            cb.Items.AddRange(citiesOfBrazil);

            return cb;
        }

        /// <summary>
        /// Retorna em um componente ComboBox a lista de cidades pertencentes ao estado do Amazonas.
        /// </summary>
        /// <param name="cb">Componente ComboBox que receberá o retorno das cidades.</param>
        public virtual ComboBox Amazonas(ComboBox cb)
        {
            citiesOfBrazil = new string[]
            {
                "Alvarães", "Amaturá", "Anamã", "Anori",
                "Apuí", "Atalaia do Norte", "Autazes",

                "Barcelos", "Barreirinha", "Benjamin Constant", "Beruri",
                "Boa Vista do Ramos", "Boca do Acre", "Borba",

                "Caapiranga", "Canutama", "Carauari",
                "Careiro", "Careiro da Várzea", "Coari", "Codajás",

                "Eirunepé", "Envira",

                "Fonte Boa",

                "Guajará",

                "Humaitá",

                "Ipixuna", "Iranduba", "Itacoatiara", "Itamarati", "Itapiranga",

                "Japurá", "Juruá", "Jutaí",

                "Lábrea",

                "Manacapuru", "Manaquiri", "Manaus", "Manicoré", "Maraã", "Maués",

                "Nhamundá", "Nova Olinda do Norte", "Novo Airão", "Novo Aripuanã",

                "Parintins", "Pauini", "Presidente Figueiredo",

                "Rio Preto da Eva",

                "Santa Isabel do Rio Negro", "Santo Antônio do Içá", "São Gabriel da Cachoeira",
                "São Paulo de Olivença", "São Sebastião do Uatumã", "Silves",

                "Tabatinga", "Tapauá", "Tefé", "Tonantins",

                "Uarini", "Urucará", "Urucurituba"
            };

            cb.Items.AddRange(citiesOfBrazil);

            return cb;
        }

        /// <summary>
        /// Retorna em um componente ComboBox a lista de cidades pertencentes ao estado da Bahia.
        /// </summary>
        /// <param name="cb">Componente ComboBox que receberá o retorno das cidades.</param>
        public virtual ComboBox Bahia(ComboBox cb)
        {
            citiesOfBrazil = new string[]
            {
                "Abaíra", "Abaré", "Acajutiba", "Adustina", "Água Fria", "Aiquara",
                "Alagoinhas", "Alcobaça", "Almadina", "Amargosa", "Amélia Rodrigues",
                "América Dourada", "Anagé", "Andaraí", "Andorinha", "Angical", "Anguera",
                "Antas", "Antônio Cardoso", "Antônio Gonçalves", "Aporá", "Apuarema",
                "Araças", "Aracatu", "Araci", "Aramari", "Arataca", "Aratuípe", "Aurelino Leal",

                "Baianópolis", "Baixa Grande", "Banzaê", "Barra", "Barra da Estiva", "Barra do Choça",
                "Barra do Mendes", "Barra do Rocha", "Barreiras", "Barro Alto", "Barro Preto", "Barrocas",
                "Belmonte", "Belo Campo", "Biritinga", "Boa Nova", "Boa Vista do Tupim", "Bom Jesus da Lapa",
                "Bom Jesus da Serra", "Boninal", "Bonito", "Boquira", "Botuporã", "Brejões", "Brejolândia",
                "Brotas de Macaúbas", "Brumado", "Buerarema", "Buritirama",

                "Caatiba", "Cabaceiras do Paraguaçu", "Cachoeira", "Caculé", "Caém", "Caetanos", "Caetité",
                "Cafarnaum", "Cairu", "Caldeirão Grande", "Camacan","Camaçari", "Camamu", "Campo Alegre de Lourdes",
                "Campo Formoso", "Canápolis", "Canarana", "Canavieiras", "Candeal", "Candeias", "Candiba", "Cândido Sales",
                "Cansanção", "Canudos", "Capela do Alto Alegre", "Capim Grosso", "Caraíbas", "Caravelas", "Cardeal da Silva",
                "Carinhanha", "Casa Nova", "Castro Alves", "Catolândia", "Catu", "Caturama", "Central", "Chorrochó", "Cícero Dantas",
                "Cipó", "Coaraci", "Cocos", "Conceição da Feira", "Conceição do Almeida", "Conceição do Coité", "Conceição do Jacuípe",
                "Conde", "Condeúba", "Contendas do Sincorá", "Coração de Maria", "Cordeiros", "Coribe", "Coronel João Sá", "Correntina",
                "Cotegipe", "Cravolândia", "Crisópolis", "Cristópolis", "Cruz das Almas", "Curaçá",

                "Dário Meira", "Dias dÁvila", "Dom Basílio", "Dom Macedo Costa",

                "Elísio Medrado", "Encruzilhada", "Entre Rios", "Érico Cardoso",
                "Esplanada", "Euclides da Cunha", "Eunápolis",

                "Fátima", "Feira da Mata", "Feira de Santana", "Filadélfia", "Firmino Alves",
                "Floresta Azul", "Formosa do Rio Preto",

                "Gandu", "Gavião", "Gentio do Ouro", "Glória", "Gongogi",
                "Governador Mangabeira", "Guajeru", "Guanambi", "Guaratinga",

                "Heliópolis",

                "Iaçu", "Ibiassucê", "Ibicaraí", "Ibicoara", "Ibicuí", "Ibipeba", "Ibipitanga", "Ibiquera",
                "Ibirapitanga", "Ibirapuã", "Ibirataia", "Ibitiara", "Ibititá", "Ibotirama", "Ichu",
                "Igaporã", "Igrapiúna", "Iguaí", "Ilhéus", "Inhambupe", "Ipecaetá", "Ipiaú", "Ipirá",
                "Ipupiara", "Irajuba", "Iramaia", "Iraquara", "Irará", "Irecê", "Itabela", "Itaberaba",
                "Itabuna", "Itacaré", "Itaeté", "Itagi", "Itagibá", "Itagimirim", "Itaguaçu da Bahia",
                "Itaju do Colônia", "Itajuípe", "Itamaraju", "Itamari", "Itambé", "Itanagra", "Itanhém",
                "Itaparica", "Itapé", "Itapebi", "Itapetinga", "Itapicuru", "Itapitanga", "Itaquara",
                "Itarantim", "Itatim", "Itiruçu", "Itiúba", "Itororó", "Ituaçu", "Ituberá", "Iuiú",

                "Jaborandi", "Jacaraci", "Jacobina", "Jaguaquara", "Jaguarari", "Jaguaripe",
                "Jandaíra", "Jequié", "Jeremoabo", "Jiquiriçá", "Jitaúna", "João Dourado",
                "Juazeiro", "Jucuruçu", "Jussara", "Jussari", "Jussiape",


                "Lafaiete Coutinho", "Lagoa Real", "Laje", "Lajedão", "Lajedinho",
                "Lajedo do Tabocal", "Lamarão", "Lapão", "Lauro de Freitas", "Lençóis",
                "Licínio de Almeida", "Livramento de Nossa Senhora", "Luís Eduardo Magalhães",

                "Macajuba", "Macarani", "Macaúbas", "Macururé", "Madre de Deus", "Maetinga", "Maiquinique",
                "Mairi", "Malhada", "Malhada de Pedras", "Manoel Vitorino", "Mansidão", "Maracás",
                "Maragogipe", "Maraú", "Marcionílio Souza", "Mascote", "Mata de São João", "Matina",
                "Medeiros Neto", "Miguel Calmon", "Milagres", "Mirangaba", "Mirante", "Monte Santo",
                "Morpará", "Morro do Chapéu", "Mortugaba", "Mucugê", "Mucuri", "Mulungu do Morro",
                "Mundo Novo", "Muniz Ferreira", "Muquém de São Francisco", "Muritiba", "Mutuípe",

                "Nazaré", "Nilo Peçanha", "Nordestina", "Nova Canaã", "Nova Fátima",
                "Nova Ibiá", "Nova Itarana", "Nova Redenção", "Nova Soure",
                "Nova Viçosa", "Novo Horizonte", "Novo Triunfo",

                "Olindina", "Oliveira dos Brejinhos", "Ouriçangas", "Ourolândia",

                "Palmas de Monte Alto", "Palmeiras", "Paramirim", "Paratinga", "Paripiranga",
                "Pau Brasil", "Paulo Afonso", "Pé de Serra", "Pedrão", "Pedro Alexandre",
                "Piatã", "Pilão Arcado", "Pindaí", "Pindobaçu", "Pintadas", "Piraí do Norte",
                "Piripá", "Piritiba", "Planaltino", "Planalto", "Poções", "Pojuca", "Ponto Novo",
                "Porto Seguro", "Potiraguá", "Prado", "Presidente Dutra", "Presidente Jânio Quadros",
                "Presidente Tancredo Neves",

                "Queimadas", "Quijingue", "Quixabeira",

                "Rafael Jambeiro", "Remanso", "Retirolândia", "Riachão das Neves", "Riachão do Jacuípe",
                "Riacho de Santana", "Ribeira do Amparo", "Ribeira do Pombal", "Ribeirão do Largo",
                "Rio de Contas", "Rio do Antônio", "Rio do Pires", "Rio Real", "Rodelas", "Ruy Barbosa",

                "Salinas da Margarida", "Salvador", "Santa Bárbara", "Santa Brígida", "Santa Cruz Cabrália",
                "Santa Cruz da Vitória", "Santa Inês", "Santa Luzia", "Santa Maria da Vitória", "Santa Rita de Cássia",
                "Santa Teresinha", "Santaluz", "Santana", "Santanópolis", "Santo Amaro", "Santo Antônio de Jesus",
                "Santo Estêvão", "São Desidério", "São Domingos", "São Felipe", "São Félix", "São Félix do Coribe",
                "São Francisco do Conde", "São Gabriel", "São Gonçalo dos Campos", "São José da Vitória",
                "São José do Jacuípe", "São Miguel das Matas", "São Sebastião do Passé", "Sapeaçu",
                "Sátiro Dias", "Saubara", "Saúde", "Seabra", "Sebastião Laranjeiras", "Senhor do Bonfim", "Sento Sé",
                "Serra do Ramalho", "Serra Dourada", "Serra Preta", "Serrinha", "Serrolândia", "Simões Filho",
                "Sítio do Mato", "Sítio do Quinto", "Sobradinho", "Souto Soares",

                "Tabocas do Brejo Velho", "Tanhaçu", "Tanque Novo", "Tanquinho", "Taperoá",
                "Tapiramutá", "Teixeira de Freitas", "Teodoro Sampaio", "Teofilândia",
                "Teolândia", "Terra Nova", "Tremedal", "Tucano",

                "Uauá", "Ubaíra", "Ubaitaba", "Ubatã", "Uibaí",
                "Umburanas","Una", "Urandi", "Uruçuca", "Utinga",

                "Valença", "Valente", "Várzea da Roça", "Várzea do Poço", "Várzea Nova",
                "Varzedo", "Vera Cruz", "Vereda", "Vitória da Conquista",

                "Wagner", "Wanderley", "Wenceslau Guimarães",

                "Xique-Xique"
            };

            cb.Items.AddRange(citiesOfBrazil);

            return cb;
        }

        /// <summary>
        /// Retorna em um componente ComboBox a lista de cidades pertencentes ao estado de Alagoas.
        /// </summary>
        /// <param name="cb">Componente ComboBox que receberá o retorno das cidades.</param>
        public virtual ComboBox Ceará(ComboBox cb)
        {
            citiesOfBrazil = new string[]
            {
                "Abaiara", "Acarape", "Acaraú", "Acopiara", "Aiuaba",
                "Alcântaras", "Altaneira", "Alto Santo", "Amontada", "Antonina do Norte",
                "Apuiarés", "Aquiraz", "Aracati", "Aracoia", "Ararendá",
                "Araripe", "Aratuba", "Arneiro", "Assaré", "Aurora",

                "Baixio", "Banabuiú", "Barbalha", "Barreira", "Barro", "Barroquinha",
                "Baturité", "Beberibe", "Bela Cruz", "Boa Viagem", "Brejo Santo",

                "Camocim", "Campos Sales", "Canindé", "Capistrano", "Caridade",
                "Cariré", "Caririaçu", "Cariús", "Carnaubal", "Cascavel",
                "Catarina", "Catunda", "Caucaia", "Cedro", "Chaval",
                "Choró", "Chorozinho", "Coreaú", "Crateús", "Crato", "Croatá", "Cruz",

                "Deputado Irapuan Pinheiro",

                "Ererê", "Eusébio",

                "Farias Brito", "Forquilha", "Fortaleza", "Fortim", "Frecheirinha",

                "General Sampaio", "Graça", "Granja", "Granjeiro", "Groaíras",
                "Guaiúba", "Guaraciaba do Norte", "Guaramiranga",

                "Hidrolândia", "Horizonte",

                "Ibaretama", "Ibiapina", "Ibicuitinga", "Icapuí", "Icó", "Iguatu",
                "Independência", "Ipaporanga", "Ipaumirim", "Ipu", "Ipueiras", "Iracema", "Irauçuba",
                "Itaiçaba", "Itaitinga", "Itapagé", "Itapipoca", "Itapiúna", "Itarema", "Itatira",

                "Jaguaretama", "Jaguaribara", "Jaguaribe", "Jaguaruana", "Jardim",
                "Jati", "Jijoca de Jericoacoara", "Juazeiro do Norte", "Jucás",

                "Lavras da Mangabeira", "Limoeiro do Norte",

                "Madalena", "Maracanaú", "Maranguape", "Marco", "Martinópole", "Massapê",
                "Mauriti", "Meruoca", "Milagres", "Milhã", "Miraíma", "Missão Velha", "Mombaça",
                "Monsenhor Tabosa", "Morada Nova", "Moraújo", "Morrinhos", "Mucambo", "Mulungu",

                "Nova Olinda", "Nova Russas", "Novo Oriente",

                "Ocara", "Orós",

                "Pacajus", "Pacatuba", "Pacoti", "Pacujá", "Palhano", "Palmácia", "Paracuru",
                "Paraipaba", "Parambu", "Paramoti", "Pedra Branca", "Penaforte", "Pentecoste",
                "Pereiro", "Pindoretama", "Piquet Carneiro", "Pires Ferreira", "Poranga",
                "Porteiras", "Potengi", "Potiretama",

                "Quiterianópolis", "Quixadá", "Quixelô", "Quixeramobim", "Quixeré",

                "Redenção", "Reriutaba", "Russas",

                "Saboeiro", "Salitre", "Santa Quitéria", "Santana do Acaraú", "Santana do Cariri",
                "São Benedito", "São Gonçalo do Amarante", "São João do Jaguaribe", "São Luís do Curu",
                "Senador Pompeu", "Senador Sá", "Sobral", "Solonópole",

                "Tabuleiro do Norte", "Tamboril", "Tarrafas", "Tauá", "Tejuçuoca",
                "Tianguá", "Trairi", "Tururu",

                "Ubajara", "Umari", "Umirim", "Uruburetama", "Uruoca",

                "Varjota", "Várzea Alegre", "Viçosa do Ceará"
            };

            cb.Items.AddRange(citiesOfBrazil);

            return cb;
        }

        /// <summary>
        /// Retorna em um componente ComboBox a lista de cidades pertencentes ao estado de Distrito Federal.
        /// </summary>
        /// <param name="cb">Componente ComboBox que receberá o retorno das cidades.</param>
        public virtual ComboBox DistritoFederal(ComboBox cb)
        {
            citiesOfBrazil = new string[]
            {
               "Águas Claras",

               "Brasília", "Brazlândia",

               "Candangolândia", "Ceilândia", "Cruzeiro",

               "Gama", "Guará",

               "Itapoã",

               "Núcleo Bandeirante",

               "Paranoá", "Planaltina",

               "Recanto das Emas", "Riacho Fundo",

               "Samambaia", "Santa Maria", "São Sebastião", "Sobradinho",

               "Taguatinga",

               "Varjão"
            };

            return cb;
        }

        /// <summary>
        /// Retorna em um componente ComboBox a lista de cidades pertencentes ao estado do Espírito Santo.
        /// </summary>
        /// <param name="cb">Componente ComboBox que receberá o retorno das cidades.</param>
        public virtual ComboBox EspíritoSanto(ComboBox cb)
        {
            citiesOfBrazil = new string[]
            {
                "Afonso Cláudio", "Água Doce do Norte", "Águia Branca", "Alegre",
                "Alfredo Chaves", "Alto Rio Novo", "Anchieta", "Apiacá",
                "Aracruz", "Atilio Vivacqua",

                "Baixo Guandu", "Barra de São Francisco", "Boa Esperança",
                "Bom Jesus do Norte", "Brejetuba",

                "Cachoeiro de Itapemirim", "Cariacica", "Castelo",
                "Colatina", "Conceição da Barra", "Conceição do Castelo",

                "Divino de São Lourenço", "Domingos Martins", "Dores do Rio Preto",

                "Ecoporanga",

                "Fundão",

                "Governador Lindenberg", "Guaçuí", "Guarapari",

                "Ibatiba", "Ibiraçu", "Ibitirama", "Iconha", "Irupi",
                "Itaguaçu", "Itapemirim", "Itarana", "Iúna",

                "Jaguaré", "Jerônimo Monteiro", "João Neiva",

                "Laranja da Terra", "Linhares",

                "Mantenópolis", "Marataízes", "Marechal Floriano", "Marilândia",
                "Mimoso do Sul", "Montanha", "Mucurici", "Muniz Freire", "Muqui",

                "Nova Venécia",

                "Pancas", "Pedro Canário", "Pinheiros", "Piúma", "Ponto Belo", "Presidente Kennedy",

                "Rio Bananal", "Rio Novo do Sul",

                "Santa Leopoldina", "Santa Maria de Jetibá", "Santa Teresa",
                "São Domingos do Norte", "São Gabriel da Palha", "São José do Calçado",
                "São Mateus", "São Roque do Canaã", "Serra", "Sooretama",

                "Vargem Alta", "Venda Nova do Imigrante", "Viana", "Vila Pavão",
                "Vila Valério", "Vila Velha", "Vitória"
            };

            return cb;
        }

        /// <summary>
        /// Retorna em um componente ComboBox a lista de cidades pertencentes ao estado do Espírito Santo.
        /// </summary>
        /// <param name="cb">Componente ComboBox que receberá o retorno das cidades.</param>
        public virtual ComboBox Goiás(ComboBox cb)
        {
            citiesOfBrazil = new string[]
            {
                "Abadia de Goiás", "Abadiânia", "Acreúna", "Adelândia", "Água Fria de Goiás",
                "Água Limpa", "Águas Lindas de Goiás", "Alexânia", "Aloândia", "Alto Horizonte",
                "Alto Paraíso de Goiás", "Alvorada do Norte", "Amaralina", "Americano do Brasil",
                "Amorinópolis", "Anápolis", "Anhanguera", "Anicuns", "Aparecida de Goiânia",
                "Aparecida do Rio Doce", "Aporé", "Araçu", "Aragarças", "Aragoiânia", "Araguapaz",
                "Arenópolis", "Aruanã", "Aurilândia", "Avelinópolis",

                "Baliza", "Barro Alto", "Bela Vista de Goiás", "Bom Jardim de Goiás",
                "Bom Jesus de Goiás", "Bonfinópolis", "Bonópolis", "Brazabrantes",
                "Britânia", "Buriti Alegre", "Buriti de Goiás", "Buritinópolis",

                "Cabeceiras", "Cachoeira Alta", "Cachoeira de Goiás", "Cachoeira Dourada",
                "Caçu", "Caiapônia", "Caldas Novas", "Caldazinha", "Campestre de Goiás",
                "Campinaçu", "Campinorte", "Campo Alegre de Goiás", "Campo Limpo de Goiás",
                "Campos Belos", "Campos Verdes", "Carmo do Rio Verde", "Castelândia",
                "Catalão", "Caturaí", "Cavalcante", "Ceres", "Cezarina", "Chapadão do Céu",
                "Cidade Ocidental", "Cocalzinho de Goiás", "Colinas do Sul", "Córrego do Ouro",
                "Corumbá de Goiás", "Corumbaíba", "Cristalina",  "Cristianópolis",
                "Crixás", "Cromínia", "Cumari",

                "Damianópolis", "Damolândia", "Davinópolis",
                "Diorama", "Divinópolis de Goiás", "Doverlândia",

                "Edealina", "Edéia", "Estrela do Norte", "Faina", "Fazenda Nova",
                "Firminópolis", "Flores de Goiás", "Formosa", "Formoso", "Gameleira de Goiás",
                "Goianápolis", "Goiandira", "Goianésia", "Goiânia", "Goianira", "Goiás",
                "Goiatuba", "Gouvelândia", "Guapó", "Guaraíta", "Guarani de Goiás", "Guarinos",
                "Heitoraí", "Hidrolândia", "Hidrolina", "Iaciara", "Inaciolândia", "Indiara",
                "Inhumas", "Ipameri", "Ipiranga de Goiás", "Iporá", "Israelândia", "Itaberaí",
                "Itaguari", "Itaguaru", "Itajá", "Itapaci", "Itapirapuã", "Itapuranga",
                "Itarumã", "Itauçu", "Itumbiara", "Ivolândia",

                "Jandaia", "Jaraguá", "Jataí", "Jaupaci",
                "Jesúpolis", "Joviânia", "Jussara",

                "Lagoa Santa", "Leopoldo de Bulhões", "Luziânia",

                "Mairipotaba", "Mambaí", "Mara Rosa", "Marzagão", "Matrinchã",
                "Maurilândia", "Mimoso de Goiás", "Minaçu", "Mineiros", "Moiporá",
                "Monte Alegre de Goiás", "Montes Claros de Goiás", "Montividiu", "Montividiu do Norte",
                "Morrinhos", "Morro Agudo de Goiás", "Mossâmedes", "Mozarlândia",
                "Mundo Novo",  "Mutunópolis",

                "Nazário", "Nerópolis", "Niquelândia", "Nova América", "Nova Aurora",
                "Nova Crixás", "Nova Glória", "Nova Iguaçu de Goiás", "Nova Roma",
                "Nova Veneza", "Novo Brasil", "Novo Gama", "Novo Planalto",

                "Orizona", "Ouro Verde de Goiás", "Ouvidor",

                "Padre Bernardo", "Palestina de Goiás", "Palmeiras de Goiás", "Palmelo",
                "Palminópolis", "Panamá", "Paranaiguara", "Paraúna", "Perolândia", "Petrolina de Goiás",
                "Pilar de Goiás", "Piracanjuba", "Piranhas", "Pirenópolis", "Pires do Rio", "Planaltina",
                "Pontalina", "Porangatu", "Porteirão", "Portelândia", "Posse", "Professor Jamil",

                "Quirinópolis",

                "Rialma", "Rianápolis", "Rio Quente", "Rio Verde", "Rubiataba",

                "Sanclerlândia", "Santa Bárbara de Goiás", "Santa Cruz de Goiás", "Santa Fé de Goiás",
                "Santa Helena de Goiás", "Santa Isabel", "Santa Rita do Araguaia", "Santa Rita do Novo Destino",
                "Santa Rosa de Goiás", "Santa Tereza de Goiás", "Santa Terezinha de Goiás", "Santo Antônio da Barra",
                "Santo Antônio de Goiás", "Santo Antônio do Descoberto", "São Domingos", "São Francisco de Goiás",
                "São João da Paraúna", "São João dAliança", "São Luís de Montes Belos", "São Luíz do Norte",
                "São Miguel do Araguaia", "São Miguel do Passa Quatro", "São Patrício", "São Simão",
                "Senador Canedo", "Serranópolis", "Silvânia", "Simolândia", "Sítio dAbadia",

                "Taquaral de Goiás", "Teresina de Goiás", "Terezópolis de Goiás",
                "Três Ranchos", "Trindade", "Trombas", "Turvânia", "Turvelândia",

                "Uirapuru", "Uruaçu", "Uruana", "Urutaí",

                "Valparaíso de Goiás", "Varjão", "Vianópolis",
                "Vicentinópolis", "Vila Boa", "Vila Propício"
            };

            return cb;
        }

        /// <summary>
        /// Retorna em um componente ComboBox a lista de cidades pertencentes ao estado do Maranhão.
        /// </summary>
        /// <param name="cb">Componente ComboBox que receberá o retorno das cidades.</param>
        public virtual ComboBox Maranhão(ComboBox cb)
        {
            citiesOfBrazil = new string[]
            {
                "Açailândia", "Afonso Cunha", "Água Doce do Maranhão", "Alcântara",
                "Aldeias Altas", "Altamira do Maranhão", "Alto Alegre do Maranhão",
                "Alto Alegre do Pindaré", "Alto Parnaíba", "Amapá do Maranhão",
                "Amarante do Maranhão", "Anajatuba", "Anapurus", "Apicum-Açu",
                "Araguanã", "Araioses", "Arame", "Arari", "Axixá",

                "Bacabal", "Bacabeira", "Bacuri", "Bacurituba", "Balsas", "Barão de Grajaú",
                "Barra do Corda", "Barreirinhas", "Bela Vista do Maranhão", "Belágua",
                "Benedito Leite", "Bequimão", "Bernardo do Mearim", "Boa Vista do Gurupi",
                "Bom Jardim", "Bom Jesus das Selvas", "Bom Lugar", "Brejo", "Brejo de Areia",
                "Buriti", "Buriti Bravo", "Buriticupu", "Buritirana",

                "Cachoeira Grande", "Cajapió", "Cajari", "Campestre do Maranhão", "Cândido Mendes",
                "Cantanhede", "Capinzal do Norte", "Carolina", "Carutapera", "Caxias",
                "Cedral", "Central do Maranhão", "Centro do Guilherme", "Centro Novo do Maranhão",
                "Chapadinha", "Cidelândia", "Codó", "Coelho Neto", "Colinas", 
                "Conceição do Lago-Açu", "Coroatá", "Cururupu",

                "Davinópolis", "Dom Pedro", "Duque Bacelar",

                "Esperantinópolis", "Estreito",

                "Feira Nova do Maranhão", "Fernando Falcão", "Formosa da Serra Negra",
                "Fortaleza dos Nogueiras", "Fortuna",

                "Godofredo Viana", "Gonçalves Dias", "Governador Archer", "Governador Edison Lobão",
                "Governador Eugênio Barros", "Governador Luiz Rocha", "Governador Newton Bello",
                "Governador Nunes Freire", "Graça Aranha", "Grajaú", "Guimarães",

                "Humberto de Campos",

                "Icatu", "Igarapé do Meio", "Igarapé Grande", "Imperatriz",
                "Itaipava do Grajaú", "Itapecuru Mirim", "Itinga do Maranhão",

                "Jatobá", "Jenipapo dos Vieiras", "João Lisboa", "Joselândia", "Junco do Maranhão",

                "Lago da Pedra", "Lago do Junco", "Lago dos Rodrigues", "Lago Verde",
                "Lagoa do Mato", "Lagoa Grande do Maranhão", "Lajeado Novo",
                "Lima Campos", "Loreto", "Luís Domingues",

                "Magalhães de Almeida", "Maracaçumé", "Marajá do Sena", "Maranhãozinho",
                "Mata Roma", "Matinha", "Matões", "Matões do Norte", "Milagres do Maranhão",
                "Mirador", "Miranda do Norte", "Mirinzal", "Monção", "Montes Altos", "Morros",

                "Nina Rodrigues", "Nova Colinas", "Nova Iorque", "Nova Olinda do Maranhão",

                "Olho dÁgua das Cunhãs", "Olinda Nova do Maranhão",

                "Paço do Lumiar", "Palmeirândia", "Paraibano", "Parnarama", "Passagem Franca",
                "Pastos Bons", "Paulino Neves", "Paulo Ramos", "Pedreiras", "Pedro do Rosário",
                "Penalva", "Peri Mirim", "Peritoró", "Pindaré-Mirim", "Pinheiro", "Pio XII",
                "Pirapemas", "Poção de Pedras", "Porto Franco", "Porto Rico do Maranhão",
                "Presidente Dutra", "Presidente Juscelino", "Presidente Médici", "Presidente Sarney",
                "Presidente Vargas", "Primeira Cruz",

                "Raposa", "Riachão", "Ribamar Fiquene", "Rosário",

                "Sambaíba", "Santa Filomena do Maranhão", "Santa Helena", "Santa Inês",
                "Santa Luzia", "Santa Luzia do Paruá", "Santa Quitéria do Maranhão",
                "Santa Rita", "Santana do Maranhão", "Santo Amaro do Maranhão",
                "Santo Antônio dos Lopes", "São Benedito do Rio Preto", "São Bento",
                "São Bernardo", "São Domingos do Azeitão", "São Domingos do Maranhão",
                "São Félix de Balsas", "São Francisco do Brejão", "São Francisco do Maranhão",
                "São João Batista", "São João do Carú", "São João do Paraíso", "São João do Soter",
                "São João dos Patos", "São José de Ribamar", "São José dos Basílios", "São Luís",
                "São Luís Gonzaga do Maranhão", "São Mateus do Maranhão", "São Pedro da Água Branca",
                "São Pedro dos Crentes", "São Raimundo das Mangabeiras", "São Raimundo do Doca Bezerra",
                "São Roberto", "São Vicente Ferrer", "Satubinha", "Senador Alexandre Costa", "Senador La Rocque",
                "Serrano do Maranhão", "Sítio Novo", "Sucupira do Norte", "Sucupira do Riachão",

                "Tasso Fragoso", "Timbiras", "Timon", "Trizidela do Vale",
                "Tufilândia", "Tuntum", "Turiaçu", "Turilândia", "Tutóia",

                "Urbano Santos",

                "Vargem Grande", "Viana", "Vila Nova dos Martírios",
                "Vitória do Mearim", "Vitorino Freire",

                "Zé Doca"
            };

            return cb;
        }

        /// <summary>
        /// Retorna em um componente ComboBox a lista de cidades pertencentes ao estado do Mato Grosso.
        /// </summary>
        /// <param name="cb">Componente ComboBox que receberá o retorno das cidades.</param>
        public virtual ComboBox MatoGrosso(ComboBox cb)
        {
            citiesOfBrazil = new string[]
            {
                "Acorizal", "Água Boa", "Alta Floresta", "Alto Araguaia",
                "Alto Boa Vista", "Alto Garças", "Alto Paraguai", "Alto Taquari",
                "Apiacás", "Araguaiana", "Araguainha", "Araputanga",
                "Arenápolis", "Aripuanã",

                "Barão de Melgaço", "Barra do Bugres", "Barra do Garças",
                "Bom Jesus do Araguaia", "Brasnorte",

                "Cáceres", "Campinápolis", "Campo Novo do Parecis", "Campo Verde",
                "Campos de Júlio", "Canabrava do Norte", "Canarana", "Carlinda",
                "Castanheira", "Chapada dos Guimarães", "Cláudia", "Cocalinho",
                "Colíder", "Colniza", "Comodoro", "Confresa", "Conquista DOeste",
                "Cotriguaçu", "Cuiabá", "Curvelândia",

                "Denise", "Diamantino", "Dom Aquino",

                "Feliz Natal", "Figueirópolis DOeste",

                "Gaúcha do Norte", "General Carneiro", "Glória DOeste",
                "Guarantã do Norte", "Guiratinga",

                "Indiavaí", "Ipiranga do Norte", "Itanhangá",
                "Itaúba", "Itiquira",

                "Jaciara", "Jangada", "Jauru", "Juara",
                "Juína", "Juruena", "Juscimeira",

                "Lambari DOeste", "Lucas do Rio Verde", "Luciara",

                "Marcelândia", "Matupá", "Mirassol DOeste",

                "Nobres", "Nortelândia", "Nossa Senhora do Livramento", "Nova Bandeirantes",
                "Nova Brasilândia", "Nova Canaã do Norte", "Nova Guarita", "Nova Lacerda",
                "Nova Marilândia", "Nova Maringá", "Nova Monte Verde", "Nova Mutum",
                "Nova Nazaré", "Nova Olímpia", "Nova Santa Helena", "Nova Ubiratã",
                "Nova Xavantina", "Novo Horizonte do Norte", "Novo Mundo",
                "Novo Santo Antônio", "Novo São Joaquim",

                "Paranaíta", "Paranatinga", "Pedra Preta", "Peixoto de Azevedo", "Planalto da Serra",
                "Poconé", "Pontal do Araguaia", "Ponte Branca", "Pontes e Lacerda", 
                "Porto Alegre do Norte", "Porto dos Gaúchos", "Porto Esperidião",
                "Porto Estrela", "Poxoréo", "Primavera do Leste",

                "Querência",

                "Reserva do Cabaçal", "Ribeirão Cascalheira", "Ribeirãozinho",
                "Rio Branco", "Rondolândia", "Rondonópolis", "Rosário Oeste",

                "Salto do Céu", "Santa Carmem", "Santa Cruz do Xingu", "Santa Rita do Trivelato", "Santa Terezinha",
                "Santo Afonso", "Santo Antônio do Leste", "Santo Antônio do Leverger", "São Félix do Araguaia",
                "São José do Povo", "São José do Rio Claro", "São José do Xingu", "São José dos Quatro Marcos",
                "São Pedro da Cipa", "Sapezal", "Serra Nova Dourada", "Sinop", "Sorriso",

                "Tabaporã", "Tangará da Serra", "Tapurah", "Terra Nova do Norte", "Tesouro", "Torixoréu",

                "União do Sul",

                "Vale de São Domingos", "Várzea Grande", "Vera",
                "Vila Bela da Santíssima Trindade", "Vila Rica"
            };

            return cb;
        }

        /// <summary>
        /// Retorna em um componente ComboBox a lista de cidades pertencentes ao estado do Mato Grosso do Sul.
        /// </summary>
        /// <param name="cb">Componente ComboBox que receberá o retorno das cidades.</param>
        public virtual ComboBox MatoGrossoDoSul (ComboBox cb)
        {
            citiesOfBrazil = new string[]
            {
                "Água Clara", "Alcinópolis", "Amambai", "Anastácio",
                "Anaurilândia", "Angélica", "Antônio João", "Aparecida do Taboado",
                "Aquidauana", "Aral Moreira",

                "Bandeirantes", "Bataguassu", "Batayporã", "Bela Vista",
                "Bodoquena", "Bonito", "Brasilândia",

                "Caarapó", "Camapuã", "Campo Grande", "Caracol", "Cassilândia",
                "Chapadão do Sul", "Corguinho", "Coronel Sapucaia",
                "Corumbá", "Costa Rica", "Coxim",

                "Deodápolis", "Dois Irmãos do Buriti", "Douradina", "Dourados",

                "Eldorado",

                "Fátima do Sul", "Figueirão",

                "Glória de Dourados", "Guia Lopes da Laguna",

                "Iguatemi", "Inocência", "Itaporã", 
                "Itaquiraí", "Ivinhema",

                "Japorã", "Jaraguari", "Jardim", 
                "Jateí", "Juti",

                "Ladário",
                "Laguna Carapã",

                "Maracaju", "Miranda", "Mundo Novo",

                "Naviraí", "Nioaque", "Nova Alvorada do Sul",
                "Nova Andradina", "Novo Horizonte do Sul",

                "Paranaíba", "Paranhos", "Pedro Gomes",
                "Ponta Porã", "Porto Murtinho",

                "Ribas do Rio Pardo", "Rio Brilhante", "Rio Negro",
                "Rio Verde de Mato Grosso", "Rochedo",

                "Santa Rita do Pardo", "São Gabriel do Oeste", "Selvíria",
                "Sete Quedas", "Sidrolândia", "Sonora",

                "Tacuru", "Taquarussu", "Terenos", "Três Lagoas",

                "Vicentina"
            };

            return cb;
        }

        /// <summary>
        /// Retorna em um componente ComboBox a lista de cidades pertencentes ao estado de Minas Gerais.
        /// </summary>
        /// <param name="cb">Componente ComboBox que receberá o retorno das cidades.</param>
        public virtual ComboBox MinasGerais (ComboBox cb)
        {
            citiesOfBrazil = new string[]
            {
                "Abadia dos Dourados", "Abaeté", "Abre Campo", "Acaiaca", "Açucena",
                "Água Boa", "Água Comprida", "Aguanil", "Águas Formosas", "Águas Vermelhas",
                "Aimorés", "Aiuruoca", "Alagoa", "Albertina", "Além Paraíba", "Alfenas",
                "Alfredo Vasconcelos", "Almenara", "Alpercata", "Alpinópolis", "Alterosa",
                "Alto Caparaó", "Alto Jequitibá", "Alto Rio Doce", "Alvarenga", "Alvinópolis",
                "Alvorada de Minas", "Amparo do Serra", "Andradas", "Andrelândia", "Angelândia",
                "Antônio Carlos", "Antônio Dias", "Antônio Prado de Minas", "Araçaí", "Aracitaba",
                "Araçuaí", "Araguari", "Arantina", "Araponga", "Araporã", "Arapuá", "Araújos",
                "Araxá", "Arceburgo", "Arcos", "Areado", "Argirita", "Aricanduva", "Arinos",
                "Astolfo Dutra", "Ataléia", "Augusto de Lima",

                "Baependi", "Baldim", "Bambuí", "Bandeira", "Bandeira do Sul", "Barão de Cocais",
                "Barão de Monte Alto", "Barbacena", "Barra Longa", "Barroso", "Bela Vista de Minas",
                "Belmiro Braga", "Belo Horizonte", "Belo Oriente", "Belo Vale", "Berilo", "Berizal",
                "Bertópolis", "Betim", "Bias Fortes", "Bicas", "Biquinhas", "Boa Esperança",
                "Bocaina de Minas", "Bocaiúva", "Bom Despacho", "Bom Jardim de Minas", "Bom Jesus da Penha",
                "Bom Jesus do Amparo", "Bom Jesus do Galho", "Bom Repouso", "Bom Sucesso", "Bonfim",
                "Bonfinópolis de Minas", "Bonito de Minas", "Borda da Mata", "Botelhos", "Botumirim",
                "Brás Pires", "Brasilândia de Minas", "Brasília de Minas", "Brasópolis", "Braúnas",
                "Brumadinho", "Bueno Brandão", "Buenópolis", "Bugre", "Buritis", "Buritizeiro",

                "Cabeceira Grande", "Cabo Verde", "Cachoeira da Prata", "Cachoeira de Minas", "Cachoeira de Pajeú",
                "Cachoeira Dourada", "Caetanópolis", "Caeté", "Caiana", "Cajuri", "Caldas", "Camacho", "Camanducaia",
                "Cambuí", "Cambuquira", "Campanário", "Campanha", "Campestre", "Campina Verde", "Campo Azul",
                "Campo Belo", "Campo do Meio", "Campo Florido", "Campos Altos", "Campos Gerais", "Cana Verde",
                "Canaã", "Canápolis", "Candeias", "Cantagalo", "Caparaó", "Capela Nova", "Capelinha", "Capetinga",
                "Capim Branco", "Capinópolis", "Capitão Andrade", "Capitão Enéas", "Capitólio", "Caputira",
                "Caraí", "Caranaíba", "Carandaí", "Carangola", "Caratinga", "Carbonita", "Careaçu", "Carlos Chagas",
                "Carmésia", "Carmo da Cachoeira", "Carmo da Mata", "Carmo de Minas", "Carmo do Cajuru", "Carmo do Paranaíba",
                "Carmo do Rio Claro", "Carmópolis de Minas", "Carneirinho", "Carrancas", "Carvalhópolis", "Carvalhos",
                "Casa Grande", "Cascalho Rico", "Cássia", "Cataguases", "Catas Altas", "Catas Altas da Noruega",
                "Catuji", "Catuti", "Caxambu", "Cedro do Abaeté", "Central de Minas", "Centralina", "Chácara",
                "Chalé", "Chapada do Norte", "Chapada Gaúcha", "Chiador", "Cipotânea", "Claraval", "Claro dos Poções",
                "Cláudio", "Coimbra", "Coluna", "Comendador Gomes", "Comercinho", "Conceição da Aparecida", "Conceição da Barra de Minas",
                "Conceição das Alagoas", "Conceição das Pedras", "Conceição de Ipanema", "Conceição do Mato Dentro",
                "Conceição do Pará", "Conceição do Rio Verde", "Conceição dos Ouros", "Cônego Marinho", "Confins",
                "Congonhal", "Congonhas", "Congonhas do Norte", "Conquista", "Conselheiro Lafaiete", "Conselheiro Pena",
                "Consolação", "Contagem", "Coqueiral", "Coração de Jesus", "Cordisburgo", "Cordislândia", "Corinto",
                "Coroaci", "Coromandel", "Coronel Fabriciano", "Coronel Murta", "Coronel Pacheco", "Coronel Xavier Chaves",
                "Córrego Danta", "Córrego do Bom Jesus", "Córrego Fundo", "Córrego Novo", "Couto de Magalhães de Minas",
                "Crisólita", "Cristais", "Cristália", "Cristiano Otoni", "Cristina", "Crucilândia", "Cruzeiro da Fortaleza",
                "Cruzília", "Cuparaque", "Curral de Dentro", "Curvelo",

                "Datas", "Delfim Moreira", "Delfinópolis", "Delta", "Descoberto", "Desterro de Entre Rios",
                "Desterro do Melo", "Diamantina", "Diogo de Vasconcelos", "Dionísio", "Divinésia",
                "Divino", "Divino das Laranjeiras", "Divinolândia de Minas", "Divinópolis", "Divisa Alegre",
                "Divisa Nova", "Divisópolis", "Dom Bosco", "Dom Cavati", "Dom Joaquim", "Dom Silvério",
                "Dom Viçoso", "Dona Eusébia", "Dores de Campos", "Dores de Guanhães", "Dores do Indaiá",
                "Dores do Turvo", "Doresópolis", "Douradoquara", "Durandé",

                "Elói Mendes", "Engenheiro Caldas", "Engenheiro Navarro", "Entre Folhas", "Entre Rios de Minas", 
                "Ervália", "Esmeraldas", "Espera Feliz", "Espinosa", "Espírito Santo do Dourado", "Estiva",
                "Estrela Dalva", "Estrela do Indaiá", "Estrela do Sul", "Eugenópolis", "Ewbank da Câmara", "Extrema",

                "Fama", "Faria Lemos", "Felício dos Santos", "Felisburgo", "Felixlândia", "Fernandes Tourinho",
                "Ferros", "Fervedouro", "Florestal", "Formiga", "Formoso", "Fortaleza de Minas", "Fortuna de Minas",
                "Francisco Badaró", "Francisco Dumont", "Francisco Sá", "Franciscópolis", "Frei Gaspar",
                "Frei Inocêncio", "Frei Lagonegro", "Fronteira", "Fronteira dos Vales", "Fruta de Leite",
                "Frutal", "Funilândia",

                "Galiléia", "Gameleiras", "Glaucilândia", "Goiabeira", "Goianá", "Gonçalves", "Gonzaga",
                "Gouveia", "Governador Valadares", "Grão Mogol", "Grupiara", "Guanhães", "Guapé",
                "Guaraciaba", "Guaraciama", "Guaranésia", "Guarani", "Guarará", "Guarda-Mor", "Guaxupé",
                "Guidoval", "Guimarânia", "Guiricema", "Gurinhatã", 

                "Heliodora",

                "Iapu", "Ibertioga", "Ibiá", "Ibiaí", "Ibiracatu", "Ibiraci", "Ibirité", "Ibitiúra de Minas",
                "Ibituruna", "Icaraí de Minas", "Igarapé", "Igaratinga", "Iguatama", "Ijaci", "Ilicínea",
                "Imbé de Minas", "Inconfidentes", "Indaiabira", "Indianópolis", "Ingaí", "Inhapim",
                "Inhaúma", "Inimutaba", "Ipaba", "Ipanema", "Ipatinga", "Ipiaçu", "Ipuiúna", "Iraí de Minas",
                "Itabira", "Itabirinha", "Itabirito", "Itacambira", "Itacarambi", "Itaguara", "Itaipé", 
                "Itajubá", "Itamarandiba", "Itamarati de Minas", "Itambacuri", "Itambé do Mato Dentro",
                "Itamogi", "Itamonte", "Itanhandu", "Itanhomi", "Itaobim", "Itapagipe", "Itapecerica",
                "Itapeva", "Itatiaiuçu", "Itaú de Minas", "Itaúna", "Itaverava", "Itinga", "Itueta",
                "Ituiutaba", "Itumirim", "Iturama", "Itutinga",

                "Jaboticatubas", "Jacinto", "Jacuí", "Jacutinga", "Jaguaraçu", "Jaíba", "Jampruca",
                "Janaúba", "Januária", "Japaraíba", "Japonvar", "Jeceaba", "Jenipapo de Minas", "Jequeri",
                "Jequitaí", "Jequitibá", "Jequitinhonha", "Jesuânia", "Joaíma", "Joanésia",
                "João Monlevade", "João Pinheiro", "Joaquim Felício", "Jordânia", "José Gonçalves de Minas",
                "José Raydan", "Josenópolis", "Juatuba", "Juiz de Fora", "Juramento", "Juruaia", "Juvenília",

                "Ladainha", "Lagamar", "Lagoa da Prata", "Lagoa dos Patos", "Lagoa Dourada", "Lagoa Formosa",
                "Lagoa Grande", "Lagoa Santa", "Lajinha", "Lambari", "Lamim", "Laranjal", "Lassance", "Lavras",
                "Leandro Ferreira", "Leme do Prado", "Leopoldina", "Liberdade", "Lima Duarte", "Limeira do Oeste",
                "Lontra", "Luisburgo", "Luislândia", "Luminárias", "Luz",

                "Machacalis", "Machado", "Madre de Deus de Minas", "Malacacheta", "Mamonas", "Manga", "Manhuaçu",
                "Manhumirim", "Mantena", "Mar de Espanha", "Maravilhas", "Maria da Fé", "Mariana", "Marilac",
                "Mário Campos", "Maripá de Minas", "Marliéria", "Marmelópolis", "Martinho Campos", "Martins Soares",
                "Mata Verde", "Materlândia", "Mateus Leme", "Mathias Lobato", "Matias Barbosa", "Matias Cardoso",
                "Matipó", "Mato Verde", "Matozinhos", "Matutina", "Medeiros", "Medina", "Mendes Pimentel", "Mercês",
                "Mesquita", "Minas Novas", "Minduri", "Mirabela", "Miradouro", "Miraí", "Miravânia", "Moeda", "Moema",
                "Monjolos", "Monsenhor Paulo", "Montalvânia", "Monte Alegre de Minas", "Monte Azul", "Monte Belo",
                "Monte Carmelo", "Monte Formoso", "Monte Santo de Minas", "Monte Sião", "Montes Claros", "Montezuma",
                "Morada Nova de Minas", "Morro da Garça", "Morro do Pilar", "Munhoz", "Muriaé", "Mutum", "Muzambinho",

                "Nacip Raydan", "Nanuque", "Naque", "Natalândia", "Natércia", "Nazareno", "Nepomuceno", "Ninheira",
                "Nova Belém", "Nova Era", "Nova Lima", "Nova Módica", "Nova Ponte", "Nova Porteirinha", "Nova Resende",
                "Nova Serrana", "Nova União", "Novo Cruzeiro", "Novo Oriente de Minas", "Novorizonte",

                "Olaria", "Olhos-dÁgua", "Olímpio Noronha", "Oliveira", "Oliveira Fortes", "Onça de Pitangui",
                "Oratórios", "Orizânia", "Ouro Branco", "Ouro Fino", "Ouro Preto", "Ouro Verde de Minas",

                "Padre Carvalho", "Padre Paraíso", "Pai Pedro", "Paineiras", "Pains", "Paiva", "Palma",
                "Palmópolis", "Papagaios", "Pará de Minas", "Paracatu", "Paraguaçu", "Paraisópolis",
                "Paraopeba", "Passa Quatro", "Passa Tempo", "Passa-Vinte", "Passabém", "Passos",
                "Patis", "Patos de Minas", "Patrocínio", "Patrocínio do Muriaé", "Paula Cândido",
                "Paulistas", "Pavão", "Peçanha", "Pedra Azul", "Pedra Bonita", "Pedra do Anta",
                "Pedra do Indaiá", "Pedra Dourada", "Pedralva", "Pedras de Maria da Cruz", "Pedrinópolis",
                "Pedro Leopoldo", "Pedro Teixeira", "Pequeri", "Pequi", "Perdigão", "Perdizes", "Perdões",
                "Periquito", "Pescador", "Piau", "Piedade de Caratinga", "Piedade de Ponte Nova",
                "Piedade do Rio Grande", "Piedade dos Gerais", "Pimenta", "Pingo-dÁgua", "Pintópolis",
                "Piracema", "Pirajuba", "Piranga", "Piranguçu", "Piranguinho", "Pirapetinga",
                "Pirapora", "Piraúba", "Pitangui", "Piumhi", "Planura", "Poço Fundo", "Poços de Caldas",
                "Pocrane", "Pompéu", "Ponte Nova", "Ponto Chique", "Ponto dos Volantes", "Porteirinha",
                "Porto Firme", "Poté", "Pouso Alegre", "Pouso Alto", "Prados", "Prata", "Pratápolis",
                "Pratinha", "Presidente Bernardes", "Presidente Juscelino", "Presidente Kubitschek",
                "Presidente Olegário", "Prudente de Morais",

                "Quartel Geral", "Queluzito",

                "Raposos", "Raul Soares", "Recreio", "Reduto", "Resende Costa", "Resplendor", "Ressaquinha",
                "Riachinho", "Riacho dos Machados", "Ribeirão das Neves", "Ribeirão Vermelho", "Rio Acima",
                "Rio Casca", "Rio do Prado", "Rio Doce", "Rio Espera", "Rio Manso", "Rio Novo", "Rio Paranaíba",
                "Rio Pardo de Minas", "Rio Piracicaba", "Rio Pomba", "Rio Preto", "Rio Vermelho", "Ritápolis", 
                "Rochedo de Minas", "Rodeiro", "Romaria", "Rosário da Limeira", "Rubelita", "Rubim",

                "Sabará", "Sabinópolis", "Sacramento", "Salinas", "Salto da Divisa", "Santa Bárbara", 
                "Santa Bárbara do Leste", "Santa Bárbara do Monte Verde", "Santa Bárbara do Tugúrio",
                "Santa Cruz de Minas", "Santa Cruz de Salinas", "Santa Cruz do Escalvado", "Santa Efigênia de Minas",
                "Santa Fé de Minas", "Santa Helena de Minas", "Santa Juliana", "Santa Luzia", "Santa Margarida",
                "Santa Maria de Itabira", "Santa Maria do Salto", "Santa Maria do Suaçuí", "Santa Rita de Caldas",
                "Santa Rita de Ibitipoca", "Santa Rita de Jacutinga", "Santa Rita de Minas", "Santa Rita do Itueto",
                "Santa Rita do Sapucaí", "Santa Rosa da Serra", "Santa Vitória", "Santana da Vargem", "Santana de Cataguases",
                "Santana de Pirapama", "Santana do Deserto", "Santana do Garambéu", "Santana do Jacaré", "Santana do Manhuaçu",
                "Santana do Paraíso", "Santana do Riacho", "Santana dos Montes", "Santo Antônio do Amparo", "Santo Antônio do Aventureiro",
                "Santo Antônio do Grama", "Santo Antônio do Itambé", "Santo Antônio do Jacinto", "Santo Antônio do Monte",
                "Santo Antônio do Retiro", "Santo Antônio do Rio Abaixo", "Santo Hipólito", "Santos Dumont", "São Bento Abade", "São Brás do Suaçuí",
                "São Domingos das Dores", "São Domingos do Prata", "São Félix de Minas", "São Francisco", "São Francisco de Paula",
                "São Francisco de Sales", "São Francisco do Glória", "São Geraldo", "São Geraldo da Piedade", "São Geraldo do Baixio",
                "São Gonçalo do Abaeté", "São Gonçalo do Pará", "São Gonçalo do Rio Abaixo", "São Gonçalo do Rio Preto",
                "São Gonçalo do Sapucaí", "São Gotardo", "São João Batista do Glória", "São João da Lagoa", "São João da Mata",
                "São João da Ponte", "São João das Missões", "São João del Rei", "São João do Manhuaçu", "São João do Manteninha",
                "São João do Oriente", "São João do Pacuí", "São João do Paraíso", "São João Evangelista", "São João Nepomuceno",
                "São Joaquim de Bicas", "São José da Barra", "São José da Lapa", "São José da Safira", "São José da Varginha",
                "São José do Alegre", "São José do Divino", "São José do Goiabal", "São José do Jacuri", "São José do Mantimento",
                "São Lourenço", "São Miguel do Anta", "São Pedro da União", "São Pedro do Suaçuí", "São Pedro dos Ferros", "São Romão",
                "São Roque de Minas", "São Sebastião da Bela Vista", "São Sebastião da Vargem Alegre", "São Sebastião do Anta",
                "São Sebastião do Maranhão", "São Sebastião do Oeste", "São Sebastião do Paraíso", "São Sebastião do Rio Preto",
                "São Sebastião do Rio Verde", "São Thomé das Letras", "São Tiago", "São Tomás de Aquino", "São Vicente de Minas",
                "Sapucaí-Mirim", "Sardoá", "Sarzedo", "Sem-Peixe", "Senador Amaral", "Senador Cortes", "Senador Firmino",
                "Senador José Bento", "Senador Modestino Gonçalves", "Senhora de Oliveira", "Senhora do Porto", "Senhora dos Remédios",
                "Sericita", "Seritinga", "Serra Azul de Minas", "Serra da Saudade", "Serra do Salitre", "Serra dos Aimorés",
                "Serrania", "Serranópolis de Minas", "Serranos", "Serro", "Sete Lagoas", "Setubinha", "Silveirânia", "Silvianópolis",
                "Simão Pereira", "Simonésia", "Sobrália", "Soledade de Minas",

                "Tabuleiro", "Taiobeiras", "Taparuba", "Tapira", "Tapiraí", "Taquaraçu de Minas", "Tarumirim", "Teixeiras",
                "Teófilo Otoni", "Timóteo", "Tiradentes", "Tiros", "Tocantins", "Tocos do Moji", "Toledo", "Tombos",
                "Três Corações", "Três Marias", "Três Pontas", "Tumiritinga", "Tupaciguara", "Turmalina", "Turvolândia",

                "Ubá", "Ubaí", "Ubaporanga", "Uberaba", "Uberlândia", "Umburatiba",
                "Unaí", "União de Minas", "Uruana de Minas", "Urucânia", "Urucuia",

                "Vargem Alegre", "Vargem Bonita", "Vargem Grande do Rio Pardo", "Varginha", "Varjão de Minas",
                "Várzea da Palma", "Varzelândia", "Vazante", "Verdelândia", "Veredinha",
                "Veríssimo", "Vermelho Novo", "Vespasiano", "Viçosa", "Vieiras", "Virgem da Lapa",
                "Virgínia", "Virginópolis", "Virgolândia", "Visconde do Rio Branco", "Volta Grande",

                "Wenceslau Braz",
            };

            return cb;
        }

        /// <summary>
        /// Retorna em um componente ComboBox a lista de cidades pertencentes ao estado do Pará.
        /// </summary>
        /// <param name="cb">Componente ComboBox que receberá o retorno das cidades.</param>
        public virtual ComboBox Pará (ComboBox cb)
        {
            citiesOfBrazil = new string[]
            {
                "Abaetetuba", "Abel Figueiredo", "Acará", "Afuá", "Água Azul do Norte",
                "Alenquer", "Almeirim", "Altamira", "Anajás", "Ananindeua", "Anapu",
                "Augusto Corrêa", "Aurora do Pará", "Aveiro",

                "Bagre", "Baião", "Bannach", "Barcarena", "Belém", "Belterra",
                "Benevides", "Bom Jesus do Tocantins", "Bonito", "Bragança", "Brasil Novo",
                "Brejo Grande do Araguaia", "Breu Branco", "Breves", "Bujaru",

                "Cachoeira do Arari", "Cachoeira do Piriá", "Cametá", "Canaã dos Carajás",
                "Capanema", "Capitão Poço", "Castanhal", "Chaves", "Colares",
                "Conceição do Araguaia", "Concórdia do Pará", "Cumaru do Norte",
                "Curionópolis", "Curralinho", "Curuá", "Curuçá",

                "Dom Eliseu",

                "Eldorado dos Carajás",

                "Faro", "Floresta do Araguaia",

                "Garrafão do Norte", "Goianésia do Pará", "Gurupá",

                "Igarapé-Açu", "Igarapé-Miri", "Inhangapi", "Ipixuna do Pará",
                "Irituia", "Itaituba", "Itupiranga",

                "Jacareacanga", "Jacundá", "Juruti",

                "Limoeiro do Ajuru",

                "Mãe do Rio", "Magalhães Barata", "Marabá", "Maracanã", "Marapanim", "Marituba",
                "Medicilândia", "Melgaço", "Mocajuba", "Moju", "Monte Alegre", "Muaná",

                "Nova Esperança do Piriá", "Nova Ipixuna", "Nova Timboteua",
                "Novo Progresso", "Novo Repartimento",

                "Óbidos", "Oeiras do Pará", "Oriximiná",
                "Ourém", "Ourilândia do Norte",

                "Pacajá", "Palestina do Pará", "Paragominas", "Parauapebas",
                "Pau DArco", "Peixe-Boi", "Piçarra", "Placas", "Ponta de Pedras",
                "Portel", "Porto de Moz", "Prainha", "Primavera",

                "Quatipuru",

                "Redenção", "Rio Maria", "Rondon do Pará", "Rurópolis",

                "Salinópolis", "Salvaterra", "Santa Bárbara do Pará", "Santa Cruz do Arari",
                "Santa Isabel do Pará", "Santa Luzia do Pará", "Santa Maria das Barreiras",
                "Santa Maria do Pará", "Santana do Araguaia", "Santarém", "Santarém Novo",
                "Santo Antônio do Tauá", "São Caetano de Odivelas", "São Domingos do Araguaia",
                "São Domingos do Capim", "São Félix do Xingu", "São Francisco do Pará",
                "São Geraldo do Araguaia", "São João da Ponta", "São João de Pirabas",
                "São João do Araguaia", "São Miguel do Guamá", "São Sebastião da Boa Vista",
                "Sapucaia", "Senador José Porfírio", "Soure",

                "Tailândia", "Terra Alta", "Terra Santa", "Tomé-Açu",
                "Tracuateua", "Trairão", "Tucumã", "Tucuruí",

                "Ulianópolis", "Uruará",

                "Vigia", "Viseu", "Vitória do Xingu",

                "Xinguara"
            };

            return cb;
        }
    }
}
