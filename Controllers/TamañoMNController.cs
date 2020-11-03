using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using WebApplication1.Models;
using System.Data;
using System.Data.Sql;

namespace WebApplication1.Controllers
{
    public class TamañoMNController : Controller
    {
        XmlDocument doc = new XmlDocument();
        List<string> Ficha;

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public string Color(List<string> color1, List<string> color2)
        {
            Session["contadorJ1"] = 0;
            Session["contadorJ2"] = 0;
            Session["contadorG"] = 0;
            Session["jugador1"] = color1;
            Session["jugador2"] = color2;
            return " ";
        }

        public string AnchoAlto(int Tancho, int Talto)
        {
            string cadena = "";
            List<string> posiciones1 = new List<string>() { "A1", "B1", "C1", "D1", "E1", "F1", "G1", "H1", "I1", "J1", "K1", "L1", "M1", "N1", "O1", "P1", "Q1", "R1", "S1", "T1" };
            List<string> posiciones2 = new List<string>() { "A2", "B2", "C2", "D2", "E2", "F2", "G2", "H2", "I2", "J2", "K2", "L2", "M2", "N2", "O2", "P2", "Q2", "R2", "S2", "T2" };
            List<string> posiciones3 = new List<string>() { "A3", "B3", "C3", "D3", "E3", "F3", "G3", "H3", "I3", "J3", "K3", "L3", "M3", "N3", "O3", "P3", "Q3", "R3", "S3", "T3" };
            List<string> posiciones4 = new List<string>() { "A4", "B4", "C4", "D4", "E4", "F4", "G4", "H4", "I4", "J4", "K4", "L4", "M4", "N4", "O4", "P4", "Q4", "R4", "S4", "T4" };
            List<string> posiciones5 = new List<string>() { "A5", "B5", "C5", "D5", "E5", "F5", "G5", "H5", "I5", "J5", "K5", "L5", "M5", "N5", "O5", "P5", "Q5", "R5", "S5", "T5" };
            List<string> posiciones6 = new List<string>() { "A6", "B6", "C6", "D6", "E6", "F6", "G6", "H6", "I6", "J6", "K6", "L6", "M6", "N6", "O6", "P6", "Q6", "R6", "S6", "T6" };
            List<string> posiciones7 = new List<string>() { "A7", "B7", "C7", "D7", "E7", "F7", "G7", "H7", "I7", "J7", "K7", "L7", "M7", "N7", "O7", "P7", "Q7", "R7", "S7", "T7" };
            List<string> posiciones8 = new List<string>() { "A8", "B8", "C8", "D8", "E8", "F8", "G8", "H8", "I8", "J8", "K8", "L8", "M8", "N8", "O8", "P8", "Q8", "R8", "S8", "T8" };
            List<string> posiciones9 = new List<string>() { "A9", "B9", "C9", "D9", "E9", "F9", "G9", "H9", "I9", "J9", "K9", "L9", "M9", "N9", "O9", "P9", "Q9", "R9", "S9", "T9" };
            List<string> posiciones10 = new List<string>() { "A10", "B10", "C10", "D10", "E10", "F10", "G10", "H10", "I10", "J10", "K10", "L10", "M10", "N10", "O10", "P10", "Q10", "R10", "S10", "T10" };
            List<string> posiciones11 = new List<string>() { "A11", "B11", "C11", "D11", "E11", "F11", "G11", "H11", "I11", "J11", "K11", "L11", "M11", "N11", "O11", "P11", "Q11", "R11", "S11", "T11" };
            List<string> posiciones12 = new List<string>() { "A12", "B12", "C12", "D12", "E12", "F12", "G12", "H12", "I12", "J12", "K12", "L12", "M12", "N12", "O12", "P12", "Q12", "R12", "S12", "T12" };
            List<string> posiciones13 = new List<string>() { "A13", "B13", "C13", "D13", "E13", "F13", "G13", "H13", "I13", "J13", "K13", "L13", "M13", "N13", "O13", "P13", "Q13", "R13", "S13", "T13" };
            List<string> posiciones14 = new List<string>() { "A14", "B14", "C14", "D14", "E14", "F14", "G14", "H14", "I14", "J14", "K14", "L14", "M14", "N14", "O14", "P14", "Q14", "R14", "S14", "T14" };
            List<string> posiciones15 = new List<string>() { "A15", "B15", "C15", "D15", "E15", "F15", "G15", "H15", "I15", "J15", "K15", "L15", "M15", "N15", "O15", "P15", "Q15", "R15", "S15", "T15" };
            List<string> posiciones16 = new List<string>() { "A16", "B16", "C16", "D16", "E16", "F16", "G16", "H16", "I16", "J16", "K16", "L16", "M16", "N16", "O16", "P16", "Q16", "R16", "S16", "T16" };
            List<string> posiciones17 = new List<string>() { "A17", "B17", "C17", "D17", "E17", "F17", "G17", "H17", "I17", "J17", "K17", "L17", "M17", "N17", "O17", "P17", "Q17", "R17", "S17", "T17" };
            List<string> posiciones18 = new List<string>() { "A18", "B18", "C18", "D18", "E18", "F18", "G18", "H18", "I18", "J18", "K18", "L18", "M18", "N18", "O18", "P18", "Q18", "R18", "S18", "T18" };
            List<string> posiciones19 = new List<string>() { "A19", "B19", "C19", "D19", "E19", "F19", "G19", "H19", "I19", "J19", "K19", "L19", "M19", "N19", "O19", "P19", "Q19", "R19", "S19", "T19" };
            List<string> posiciones20 = new List<string>() { "A20", "B20", "C20", "D20", "E20", "F20", "G20", "H20", "I20", "J20", "K20", "L20", "M20", "N20", "O20", "P20", "Q20", "R20", "S20", "T20" };
            List<List<string>> posiciones = new List<List<string>> { };
            posiciones.Add(posiciones1);
            posiciones.Add(posiciones2);
            posiciones.Add(posiciones3);
            posiciones.Add(posiciones4);
            posiciones.Add(posiciones5);
            posiciones.Add(posiciones6);
            posiciones.Add(posiciones7);
            posiciones.Add(posiciones8);
            posiciones.Add(posiciones9);
            posiciones.Add(posiciones10);
            posiciones.Add(posiciones11);
            posiciones.Add(posiciones12);
            posiciones.Add(posiciones13);
            posiciones.Add(posiciones14);
            posiciones.Add(posiciones15);
            posiciones.Add(posiciones16);
            posiciones.Add(posiciones17);
            posiciones.Add(posiciones18);
            posiciones.Add(posiciones19);
            posiciones.Add(posiciones20);


            List<string> diagonal1 = new List<string>() { "A20" };
            List<string> diagonal2 = new List<string>() { "A19", "B20" };
            List<string> diagonal3 = new List<string>() { "A18", "B19", "C20" };
            List<string> diagonal4 = new List<string>() { "A17", "B18", "C19", "D20" };
            List<string> diagonal5 = new List<string>() { "A16", "B17", "C18", "D19", "E20" };
            List<string> diagonal6 = new List<string>() { "A15", "B16", "C17", "D18", "E19", "F20" };
            List<string> diagonal7 = new List<string>() { "A14", "B15", "C16", "D17", "E18", "F19", "G20" };
            List<string> diagonal8 = new List<string>() { "A13", "B14", "C15", "D16", "E17", "F18", "G19", "H20" };
            List<string> diagonal9 = new List<string>() { "A12", "B13", "C14", "D15", "E16", "F17", "G18", "H19", "I20" };
            List<string> diagonal10 = new List<string>() { "A11", "B12", "C13", "D14", "E15", "F16", "G17", "H18", "I19", "J20" };
            List<string> diagonal11 = new List<string>() { "A10", "B11", "C12", "D13", "E14", "F15", "G16", "H17", "I18", "J19", "K20" };
            List<string> diagonal12 = new List<string>() { "A9", "B10", "C11", "D12", "E13", "F14", "G15", "H16", "I17", "J18", "K19", "L20" };
            List<string> diagonal13 = new List<string>() { "A8", "B9", "C10", "D11", "E12", "F13", "G14", "H15", "I16", "J17", "K18", "L19", "M20" };
            List<string> diagonal14 = new List<string>() { "A7", "B8", "C9", "D10", "E11", "F12", "G13", "H14", "I15", "J16", "K17", "L18", "M19", "N20" };
            List<string> diagonal15 = new List<string>() { "A6", "B7", "C8", "D9", "E10", "F11", "G12", "H13", "I14", "J15", "K16", "L17", "M18", "N19", "O20" };
            List<string> diagonal16 = new List<string>() { "A5", "B6", "C7", "D8", "E9", "F10", "G11", "H12", "I13", "J14", "K15", "L16", "M17", "N18", "O19", "P20" };
            List<string> diagonal17 = new List<string>() { "A4", "B5", "C6", "D7", "E8", "F9", "G10", "H11", "I12", "J13", "K14", "L15", "M16", "N17", "O18", "P19", "Q20" };
            List<string> diagonal18 = new List<string>() { "A3", "B4", "C5", "D6", "E7", "F8", "G9", "H10", "I11", "J12", "K13", "L14", "M15", "N16", "O17", "P18", "Q19", "R20" };
            List<string> diagonal19 = new List<string>() { "A2", "B3", "C4", "D5", "E6", "F7", "G8", "H9", "I10", "J11", "K12", "L13", "M14", "N15", "O16", "P17", "Q18", "R19", "S20" };
            List<string> diagonal20 = new List<string>() { "A1", "B2", "C3", "D4", "E5", "F6", "G7", "H8", "I9", "J10", "K11", "L12", "M13", "N14", "O15", "P16", "Q17", "R18", "S19", "T20" };
            List<string> diagonal21 = new List<string>() { "B1", "C2", "D3", "E4", "F5", "G6", "H7", "I8", "J9", "K10", "L11", "M12", "N13", "O14", "P15", "Q16", "R17", "S19", "T19" };
            List<string> diagonal22 = new List<string>() { "C1", "D2", "E3", "F4", "G5", "H6", "I7", "J8", "K9", "L10", "M11", "N12", "O13", "P14", "Q15", "R16", "S17", "T18" };
            List<string> diagonal23 = new List<string>() { "D1", "E2", "F3", "G4", "H5", "I6", "J7", "K8", "L9", "M10", "N11", "O12", "P13", "Q14", "R15", "S16", "T17" };
            List<string> diagonal24 = new List<string>() { "E1", "F2", "G3", "H4", "I5", "J6", "K7", "L8", "M9", "N10", "O11", "P12", "Q13", "R14", "S15", "T16" };
            List<string> diagonal25 = new List<string>() { "F1", "G2", "H3", "I4", "J5", "K6", "L7", "M8", "N9", "O10", "P11", "Q12", "R13", "S14", "T15" };
            List<string> diagonal26 = new List<string>() { "G1", "H2", "I3", "J4", "K5", "L6", "M7", "N8", "O9", "P10", "Q11", "R12", "S13", "T14" };
            List<string> diagonal27 = new List<string>() { "H1", "I2", "J3", "K4", "L5", "M6", "N7", "O8", "P9", "Q10", "R11", "S12", "T13" };
            List<string> diagonal28 = new List<string>() { "I1", "J2", "K3", "L4", "M5", "N6", "O7", "P8", "Q9", "R10", "S11", "T12" };
            List<string> diagonal29 = new List<string>() { "J1", "K2", "L3", "M4", "N5", "O6", "P7", "Q8", "R9", "S10", "T11" };
            List<string> diagonal30 = new List<string>() { "K1", "L2", "M3", "N4", "O5", "P6", "Q7", "R8", "S9", "T10" };
            List<string> diagonal31 = new List<string>() { "L1", "M2", "N3", "O4", "P5", "Q6", "R7", "S8", "T9" };
            List<string> diagonal32 = new List<string>() { "M1", "N2", "O3", "P4", "Q5", "R6", "S7", "T8" };
            List<string> diagonal33 = new List<string>() { "N1", "O2", "P3", "Q4", "R5", "S6", "T7" };
            List<string> diagonal34 = new List<string>() { "O1", "P2", "Q3", "R4", "S5", "T6" };
            List<string> diagonal35 = new List<string>() { "P1", "Q2", "R3", "S4", "T5" };
            List<string> diagonal36 = new List<string>() { "Q1", "R2", "S3", "T4" };
            List<string> diagonal37 = new List<string>() { "R1", "S2", "T3" };
            List<string> diagonal38 = new List<string>() { "S1", "T2" };
            List<string> diagonal39 = new List<string>() { "T1" };
            List<List<string>> diagonales = new List<List<string>> { };
            diagonales.Add(diagonal1);
            diagonales.Add(diagonal2);
            diagonales.Add(diagonal3);
            diagonales.Add(diagonal4);
            diagonales.Add(diagonal5);
            diagonales.Add(diagonal6);
            diagonales.Add(diagonal7);
            diagonales.Add(diagonal8);
            diagonales.Add(diagonal9);
            diagonales.Add(diagonal10);
            diagonales.Add(diagonal11);
            diagonales.Add(diagonal12);
            diagonales.Add(diagonal13);
            diagonales.Add(diagonal14);
            diagonales.Add(diagonal15);
            diagonales.Add(diagonal16);
            diagonales.Add(diagonal17);
            diagonales.Add(diagonal18);
            diagonales.Add(diagonal19);
            diagonales.Add(diagonal20);
            diagonales.Add(diagonal21);
            diagonales.Add(diagonal22);
            diagonales.Add(diagonal23);
            diagonales.Add(diagonal24);
            diagonales.Add(diagonal25);
            diagonales.Add(diagonal26);
            diagonales.Add(diagonal27);
            diagonales.Add(diagonal28);
            diagonales.Add(diagonal29);
            diagonales.Add(diagonal30);
            diagonales.Add(diagonal31);
            diagonales.Add(diagonal32);
            diagonales.Add(diagonal33);
            diagonales.Add(diagonal34);
            diagonales.Add(diagonal35);
            diagonales.Add(diagonal36);
            diagonales.Add(diagonal37);
            diagonales.Add(diagonal38);
            diagonales.Add(diagonal39);

            List<string> posicionesHorizontales = new List<string> { };
            List<string> posicionesPunteo = new List<string> { };
            List<string> posicionesVerticales = new List<string> { };
            List<string> posicionesDiagonal1 = new List<string> { };
            List<string> posicionesDiagonal2 = new List<string> { };
            int contadorAlto = 0;
            int contadorAncho = 0;
            while (contadorAlto != Talto)
            {
                List<String> actual = posiciones[contadorAlto];
                while (contadorAncho != Tancho)
                {
                    string posicionX = actual[contadorAncho];
                    posicionesHorizontales.Add(posicionX);
                    posicionesPunteo.Add(posicionX);
                    cadena = cadena + "&" + actual[contadorAncho];
                    contadorAncho++;
                }
                posicionesHorizontales.Add(";");
                contadorAncho = 0;
                contadorAlto++;
            }

            int contadorV = 0;
            while (contadorV != Tancho)
            {
            for (int i = 0; i < Talto; i++)
                {
                    List<String> actual = posiciones[i];
                    for (int j = 0; j < Tancho; j++)
                    {
                        if(j == contadorV)
                        {
                        posicionesVerticales.Add(actual[j]);
                        }
                    }
                }
                posicionesVerticales.Add(";");
                contadorV++;
            }



            List<string> label = new List<string>() { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T" };
            int posicionFinal = Tancho - 1;
            for (int i = 0; i < diagonales.Count(); i++)
            {
                List<string> actual = diagonales[i];
                for (int j = 0; j < actual.Count(); j++)
                {
                    string toca = actual[0];
                    string posicion = "";
                    string variable = "";
                    int esta = 0;
                    if(toca.Count() == 2)
                    {
                        posicion = toca[1].ToString();
                    }
                    else
                    {
                        posicion = toca[1] + "" + toca[2];
                    }
                    int contadorD = 0;
                    if(int.Parse(posicion) <= Talto)
                    {
                        while (contadorD <= j)
                        {
                            string entra = actual[contadorD];
                            variable = entra[0].ToString();
                            if (entra.Count() == 2)
                            {
                                posicion = entra[1].ToString();
                            }
                            else
                            {
                                posicion = entra[1] + "" + entra[2];
                            }
                            esta = label.IndexOf(variable);
                            if (int.Parse(posicion) <= Talto && esta <= posicionFinal)
                            {
                                if (posicionesDiagonal1.Contains(entra) == false)
                                {
                                    if (diagonal1[0] == entra || diagonal2[0] == entra || diagonal3[0] == entra || diagonal4[0] == entra || diagonal5[0] == entra || diagonal6[0] == entra || diagonal7[0] == entra || diagonal8[0] == entra || diagonal9[0] == entra || diagonal10[0] == entra || diagonal11[0] == entra || diagonal12[0] == entra || diagonal13[0] == entra || diagonal14[0] == entra || diagonal15[0] == entra || diagonal16[0] == entra || diagonal17[0] == entra || diagonal18[0] == entra || diagonal19[0] == entra || diagonal20[0] == entra || diagonal21[0] == entra || diagonal22[0] == entra || diagonal23[0] == entra || diagonal24[0] == entra || diagonal25[0] == entra || diagonal26[0] == entra || diagonal27[0] == entra || diagonal28[0] == entra || diagonal29[0] == entra || diagonal30[0] == entra || diagonal31[0] == entra || diagonal32[0] == entra || diagonal33[0] == entra || diagonal34[0] == entra || diagonal35[0] == entra || diagonal36[0] == entra || diagonal37[0] == entra || diagonal38[0] == entra || diagonal39[0] == entra)
                                    {
                                        posicionesDiagonal1.Add(";");
                                    }
                                    posicionesDiagonal1.Add(entra);
                                }
                            }
                            contadorD++;
                        }
                    }
                }
            }

            if (Tancho == 20 && Talto == 20)
            {
                posicionesDiagonal1.Clear();
                for (int i = 0; i < diagonales.Count(); i++)
                {
                    List<string> actual = diagonales[i];
                    for (int j = 0; j < actual.Count(); j++)
                    {
                        if (diagonal1[0] == actual[j] || diagonal2[0] == actual[j] || diagonal3[0] == actual[j] || diagonal4[0] == actual[j] || diagonal5[0] == actual[j] || diagonal6[0] == actual[j] || diagonal7[0] == actual[j] || diagonal8[0] == actual[j] || diagonal9[0] == actual[j] || diagonal10[0] == actual[j] || diagonal11[0] == actual[j] || diagonal12[0] == actual[j] || diagonal13[0] == actual[j] || diagonal14[0] == actual[j] || diagonal15[0] == actual[j] || diagonal16[0] == actual[j] || diagonal17[0] == actual[j] || diagonal18[0] == actual[j] || diagonal19[0] == actual[j] || diagonal20[0] == actual[j] || diagonal21[0] == actual[j] || diagonal22[0] == actual[j] || diagonal23[0] == actual[j] || diagonal24[0] == actual[j] || diagonal25[0] == actual[j] || diagonal26[0] == actual[j] || diagonal27[0] == actual[j] || diagonal28[0] == actual[j] || diagonal29[0] == actual[j] || diagonal30[0] == actual[j] || diagonal31[0] == actual[j] || diagonal32[0] == actual[j] || diagonal33[0] == actual[j] || diagonal34[0] == actual[j] || diagonal35[0] == actual[j] || diagonal36[0] == actual[j] || diagonal37[0] == actual[j] || diagonal38[0] == actual[j] || diagonal39[0] == actual[j])
                        {
                            posicionesDiagonal1.Add(";");
                        }
                        posicionesDiagonal1.Add(actual[j]);
                    }
                }
            }



            List<string> diagonalI1 = new List<string>() { "T20" };
            List<string> diagonalI2 = new List<string>() { "T19", "S20" };
            List<string> diagonalI3 = new List<string>() { "T18", "S19", "R20" };
            List<string> diagonalI4 = new List<string>() { "T17", "S18", "R19", "Q20" };
            List<string> diagonalI5 = new List<string>() { "T16", "S17", "R18", "Q19", "P20" };
            List<string> diagonalI6 = new List<string>() { "T15", "S16", "R17", "Q18", "P19", "O20" };
            List<string> diagonalI7 = new List<string>() { "T14", "S15", "R16", "Q17", "P18", "O19", "N20" };
            List<string> diagonalI8 = new List<string>() { "T13", "S14", "R15", "Q16", "P17", "O18", "N19", "M20" };
            List<string> diagonalI9 = new List<string>() { "T12", "S13", "R14", "Q15", "P16", "O17", "N18", "M19", "L20" };
            List<string> diagonalI10 = new List<string>() { "T11", "S12", "R13", "Q14", "P15", "O16", "N17", "M18", "L19", "K20" };
            List<string> diagonalI11 = new List<string>() { "T10", "S11", "R12", "Q13", "P14", "O15", "N16", "M17", "L18", "K19", "J20" };
            List<string> diagonalI12 = new List<string>() { "T9", "S10", "R11", "Q12", "P13", "O14", "N15", "M16", "L17", "K18", "J19", "I20" };
            List<string> diagonalI13 = new List<string>() { "T8", "S9", "R10", "Q11", "P12", "O13", "N14", "M15", "L16", "K17", "J18", "I19", "H20" };
            List<string> diagonalI14 = new List<string>() { "T7", "S8", "R9", "Q10", "P11", "O12", "N13", "M14", "L15", "K16", "J17", "I18", "H19", "G20" };
            List<string> diagonalI15 = new List<string>() { "T6", "S7", "R8", "Q9", "P10", "O11", "N12", "M13", "L14", "K15", "J16", "I17", "H18", "G19", "F20" };
            List<string> diagonalI16 = new List<string>() { "T5", "S6", "R7", "Q8", "P9", "O10", "N11", "M12", "L13", "K14", "J15", "I16", "H17", "G18", "F19", "E20" };
            List<string> diagonalI17 = new List<string>() { "T4", "S5", "R6", "Q7", "P8", "O9", "N10", "M11", "L12", "K13", "J14", "I15", "H16", "G17", "F18", "E19", "D20" };
            List<string> diagonalI18 = new List<string>() { "T3", "S4", "R5", "Q6", "P7", "O8", "N9", "M10", "L11", "K12", "J13", "I14", "H15", "G16", "F17", "E18", "D19", "C20" };
            List<string> diagonalI19 = new List<string>() { "T2", "S3", "R4", "Q5", "P6", "O7", "N8", "M9", "L10", "K11", "J12", "I13", "H14", "G15", "F16", "E17", "D18", "C19", "B20" };
            List<string> diagonalI20 = new List<string>() { "T1", "S2", "R3", "Q4", "P5", "O6", "N7", "M8", "L9", "K10", "J11", "I12", "H13", "G14", "F15", "E16", "D17", "C18", "B19", "A20" };
            List<string> diagonalI21 = new List<string>() { "S1", "R2", "Q3", "P4", "O5", "N6", "M7", "L8", "K9", "J10", "I11", "H12", "G13", "F14", "E15", "D16", "C17", "B19", "A19" };
            List<string> diagonalI22 = new List<string>() { "R1", "Q2", "P3", "O4", "N5", "M6", "L7", "K8", "J9", "I10", "H11", "G12", "F13", "E14", "D15", "C16", "B17", "A18" };
            List<string> diagonalI23 = new List<string>() { "Q1", "P2", "O3", "N4", "M5", "L6", "K7", "J8", "I9", "H10", "G11", "F12", "E13", "D14", "C15", "B16", "A17" };
            List<string> diagonalI24 = new List<string>() { "P1", "O2", "N3", "M4", "L5", "K6", "J7", "I8", "H9", "G10", "F11", "E12", "D13", "C14", "B15", "A16" };
            List<string> diagonalI25 = new List<string>() { "O1", "N2", "M3", "L4", "K5", "J6", "I7", "H8", "G9", "F10", "E11", "D12", "C13", "B14", "A15" };
            List<string> diagonalI26 = new List<string>() { "N1", "M2", "L3", "K4", "J5", "I6", "H7", "G8", "F9", "E10", "D11", "C12", "B13", "A14" };
            List<string> diagonalI27 = new List<string>() { "M1", "L2", "K3", "J4", "I5", "H6", "G7", "F8", "E9", "D10", "C11", "B12", "A13" };
            List<string> diagonalI28 = new List<string>() { "L1", "K2", "J3", "I4", "H5", "G6", "F7", "E8", "D9", "C10", "B11", "A12" };
            List<string> diagonalI29 = new List<string>() { "K1", "J2", "I3", "H4", "G5", "F6", "E7", "D8", "C9", "B10", "A11" };
            List<string> diagonalI30 = new List<string>() { "J1", "I2", "H3", "G4", "F5", "E6", "D7", "C8", "B9", "A10" };
            List<string> diagonalI31 = new List<string>() { "I1", "H2", "G3", "F4", "E5", "D6", "C7", "B8", "A9" };
            List<string> diagonalI32 = new List<string>() { "H1", "G2", "F3", "E4", "D5", "C6", "B7", "A8" };
            List<string> diagonalI33 = new List<string>() { "G1", "F2", "E3", "D4", "C5", "B6", "A7" };
            List<string> diagonalI34 = new List<string>() { "F1", "E2", "D3", "C4", "B5", "A6" };
            List<string> diagonalI35 = new List<string>() { "E1", "D2", "C3", "B4", "A5" };
            List<string> diagonalI36 = new List<string>() { "D1", "C2", "B3", "A4" };
            List<string> diagonalI37 = new List<string>() { "C1", "B2", "A3" };
            List<string> diagonalI38 = new List<string>() { "B1", "A2" };
            List<string> diagonalI39 = new List<string>() { "A1" };
            List<List<string>> diagonalesI = new List<List<string>> { };
            diagonalI39.Reverse();
            diagonalI38.Reverse();
            diagonalI37.Reverse();
            diagonalI36.Reverse();
            diagonalI35.Reverse();
            diagonalI34.Reverse();
            diagonalI33.Reverse();
            diagonalI32.Reverse();
            diagonalI31.Reverse();
            diagonalI30.Reverse();
            diagonalI29.Reverse();
            diagonalI28.Reverse();
            diagonalI27.Reverse();
            diagonalI26.Reverse();
            diagonalI25.Reverse();
            diagonalI24.Reverse();
            diagonalI23.Reverse();
            diagonalI22.Reverse();
            diagonalI21.Reverse();
            diagonalI20.Reverse();
            diagonalI19.Reverse();
            diagonalI18.Reverse();
            diagonalI17.Reverse();
            diagonalI16.Reverse();
            diagonalI15.Reverse();
            diagonalI14.Reverse();
            diagonalI13.Reverse();
            diagonalI12.Reverse();
            diagonalI11.Reverse();
            diagonalI10.Reverse();
            diagonalI9.Reverse();
            diagonalI8.Reverse();
            diagonalI7.Reverse();
            diagonalI6.Reverse();
            diagonalI5.Reverse();
            diagonalI4.Reverse();
            diagonalI3.Reverse();
            diagonalI2.Reverse();
            diagonalI1.Reverse();
            diagonalesI.Add(diagonalI39);
            diagonalesI.Add(diagonalI38);
            diagonalesI.Add(diagonalI37);
            diagonalesI.Add(diagonalI36);
            diagonalesI.Add(diagonalI35);
            diagonalesI.Add(diagonalI34);
            diagonalesI.Add(diagonalI33);
            diagonalesI.Add(diagonalI32);
            diagonalesI.Add(diagonalI31);
            diagonalesI.Add(diagonalI30);
            diagonalesI.Add(diagonalI29);
            diagonalesI.Add(diagonalI28);
            diagonalesI.Add(diagonalI27);
            diagonalesI.Add(diagonalI26);
            diagonalesI.Add(diagonalI25);
            diagonalesI.Add(diagonalI24);
            diagonalesI.Add(diagonalI23);
            diagonalesI.Add(diagonalI22);
            diagonalesI.Add(diagonalI21);
            diagonalesI.Add(diagonalI20);
            diagonalesI.Add(diagonalI19);
            diagonalesI.Add(diagonalI18);
            diagonalesI.Add(diagonalI17);
            diagonalesI.Add(diagonalI16);
            diagonalesI.Add(diagonalI15);
            diagonalesI.Add(diagonalI14);
            diagonalesI.Add(diagonalI13);
            diagonalesI.Add(diagonalI12);
            diagonalesI.Add(diagonalI11);
            diagonalesI.Add(diagonalI10);
            diagonalesI.Add(diagonalI9);
            diagonalesI.Add(diagonalI8);
            diagonalesI.Add(diagonalI7);
            diagonalesI.Add(diagonalI6);
            diagonalesI.Add(diagonalI5);
            diagonalesI.Add(diagonalI4);
            diagonalesI.Add(diagonalI3);
            diagonalesI.Add(diagonalI2);
            diagonalesI.Add(diagonalI1);

            List<string> label2 = new List<string>() { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T" };
            int posicionFinal2 = Tancho - 1;
            for (int i = 0; i < diagonalesI.Count(); i++)
            {
                List<string> actual = diagonalesI[i];
                for (int j = 0; j < actual.Count(); j++)
                {
                    string toca = actual[j];
                    string posicion = "";
                    string variable = "";
                    int esta = 0;
                    if (toca.Count() == 2)
                    {
                        posicion = toca[1].ToString();
                    }
                    else
                    {
                        posicion = toca[1] + "" + toca[2];
                    }
                    int contadorD = 0;
                    if (int.Parse(posicion) <= Talto)
                    {
                        while (contadorD <= j)
                        {
                            string entra = actual[contadorD];
                            variable = entra[0].ToString();
                            if (entra.Count() == 2)
                            {
                                posicion = entra[1].ToString();
                            }
                            else
                            {
                                posicion = entra[1] + "" + entra[2];
                            }
                            esta = label.IndexOf(variable);
                            if (int.Parse(posicion) <= Talto && esta <= posicionFinal)
                            {
                                if (posicionesDiagonal2.Contains(entra) == false)
                                {
                                    if (diagonalI1[0] == entra || diagonalI2[0] == entra || diagonalI3[0] == entra || diagonalI4[0] == entra || diagonalI5[0] == entra || diagonalI6[0] == entra || diagonalI7[0] == entra || diagonalI8[0] == entra || diagonalI9[0] == entra || diagonalI10[0] == entra || diagonalI11[0] == entra || diagonalI12[0] == entra || diagonalI13[0] == entra || diagonalI14[0] == entra || diagonalI15[0] == entra || diagonalI16[0] == entra || diagonalI17[0] == entra || diagonalI18[0] == entra || diagonalI19[0] == entra || diagonalI20[0] == entra || diagonalI21[0] == entra || diagonalI22[0] == entra || diagonalI23[0] == entra || diagonalI24[0] == entra || diagonalI25[0] == entra || diagonalI26[0] == entra || diagonalI27[0] == entra || diagonalI28[0] == entra || diagonalI29[0] == entra || diagonalI30[0] == entra || diagonalI31[0] == entra || diagonalI32[0] == entra || diagonalI33[0] == entra || diagonalI34[0] == entra || diagonalI35[0] == entra || diagonalI36[0] == entra || diagonalI37[0] == entra || diagonalI38[0] == entra || diagonalI39[0] == entra)
                                    {
                                        posicionesDiagonal2.Add(";");
                                    }
                                    if (esta != 0 && int.Parse(posicion) == Talto)
                                    {
                                        posicionesDiagonal2.Add(";");
                                    }
                                    posicionesDiagonal2.Add(entra);
                                }
                            }
                            contadorD++;
                        }
                    }
                }
            }
            Session["contar"] = 0;
            Session["Punteo"] = posicionesPunteo;
            Session["Diagonal1"] = posicionesDiagonal1;
            Session["Diagonal2"] = posicionesDiagonal2;
            Session["Vertical"] = posicionesVerticales;
            Session["Horizontal"] = posicionesHorizontales;
            return cadena;
        }


        public string Tablero(int tipo)
        {
            List<String> punteos = (List<String>)Session["Punteo"];
            List<String> horizontal = (List<String>)Session["Horizontal"];
            List<String> vertical = (List<String>)Session["Vertical"];
            List<String> diagonal = (List<String>)Session["Diagonal1"];
            List<String> diagonal2 = (List<String>)Session["Diagonal2"];
            if (tipo == 1)
            {
                string listaTablero = horizontal[0];
                int contador = 1;
                while (contador != horizontal.Count())
                {
                    listaTablero = listaTablero +"&"+ horizontal[contador];
                    contador++;
                }
                return listaTablero;
            }
            if(tipo == 2)
            {
                string listaTablero = vertical[0];
                int contador = 1;
                while (contador != vertical.Count())
                {
                    listaTablero = listaTablero + "&" + vertical[contador];
                    contador++;
                }
                return listaTablero;
            }
            if (tipo == 3)
            {
                string listaTablero = diagonal[1];
                int contador = 2;
                while (contador != diagonal.Count())
                {
                    if(diagonal[contador] == ";")
                    {
                        listaTablero = listaTablero + "&;";
                    }
                    else
                    {
                    listaTablero = listaTablero+"&"+ diagonal[contador];
                    }
                    contador++;
                }
                return listaTablero;
            }
            if (tipo == 4)
            {
                string listaTablero = diagonal2[1];
                int contador = 2;
                while (contador != diagonal2.Count())
                {
                    if (diagonal2[contador] == ";")
                    {
                        listaTablero = listaTablero + "&;";
                    }
                    else
                    {
                        listaTablero = listaTablero + "&" + diagonal2[contador];
                    }
                    contador++;
                }
                return listaTablero;
            }
            if (tipo == 5)
            {
                string listaTablero = punteos[0];
                int contador = 1;
                while (contador != punteos.Count())
                {
                    listaTablero = listaTablero + "&" + punteos[contador];
                    contador++;
                }
                return listaTablero;
            }
            return "";
        }

        public string Mitad(int Tancho, int Talto)
        {
            int mitadAn = (Tancho / 2)-1;
            int mitadAl = (Talto / 2)-1;
            string cadena = "";
            List<String> horizontal = (List<String>)Session["Horizontal"];
            List<String> vertical = (List<String>)Session["Vertical"];
            List<string> hori = new List<string> { };
            for (int i = 0; i < horizontal.Count(); i++)
            {
                if(horizontal[i] != ";")
                {
                    hori.Add(horizontal[i]);
                }
            }
            List<List<string>> horizontalF = new List<List<string>> { };
            while (hori.Any())
            {
                horizontalF.Add(hori.Take(Tancho).ToList());
                hori = hori.Skip(Tancho).ToList();
            }
            List<string> verti = new List<string> { };
            for (int i = 0; i < vertical.Count(); i++)
            {
                if (vertical[i] != ";")
                {
                    verti.Add(vertical[i]);
                }
            }
            List<List<string>> verticalF = new List<List<string>> { };
            while (verti.Any())
            {
                verticalF.Add(verti.Take(Talto).ToList());
                verti = verti.Skip(Talto).ToList();
            }
            List<string> centro1 = horizontalF[mitadAl];
            string posicion1 = centro1[mitadAn];
            string posicion2 = centro1[mitadAn + 1];

            List<string> centro2 = horizontalF[mitadAl + 1];
            string posicion3 = centro2[mitadAn];
            string posicion4 = centro2[mitadAn + 1];

            cadena = posicion1 + "&" + posicion2 + "&" + posicion3 + "&" + posicion4;
            return cadena;
        }

        public string Punteo(List<string> coloresFichas)
        {
            List<String> colorJugador1 = (List<String>)Session["jugador1"];
            List<String> colorJugador2 = (List<String>)Session["jugador2"];
            List<String> fichasJ1 = new List<string> { };
            List<String> fichasJ2 = new List<string> { };
            fichasJ1.Clear();
            fichasJ2.Clear();
            for (int i = 0; i < colorJugador1.Count(); i++)
            {
                for (int j = 0; j < coloresFichas.Count(); j++)
                {
                    String ficha = coloresFichas[j];
                    String ficha1 = colorJugador1[i];
                    if(ficha1 == ficha)
                    {
                        fichasJ1.Add(ficha);
                    }
                }
            }
            for(int i = 0; i < colorJugador2.Count(); i++)
            {
                for (int j = 0; j < coloresFichas.Count(); j++)
                {
                    String ficha = coloresFichas[j];
                    String ficha1 = colorJugador2[i];
                    if (ficha1 == ficha)
                    {
                        fichasJ2.Add(ficha);
                    }
                }
            }
            string cadena1 = fichasJ1.Count().ToString();
            string cadena2 = fichasJ2.Count().ToString();

            return cadena1+"&"+cadena2;
        }

        public string ColoresUsuario()
        {
            try
            {
                List<String> colorJugador1 = (List<String>)Session["jugador1"];
                List<String> colorJugador2 = (List<String>)Session["jugador2"];
                int contador1 = (int)Session["contadorJ1"];
                int contador2 = (int)Session["contadorJ2"];
                int contadorG = (int)Session["contadorG"];
                var cadena = "";
                if (contadorG % 2 == 0)
                {
                    if (contador1 == colorJugador1.Count)
                    {
                        contador1 = 0;
                    }
                    cadena = colorJugador1[contador1];
                    contador1 = contador1 + 1;
                }
                else
                {
                    if (contador2 == colorJugador2.Count)
                    {
                        contador2 = 0;
                    }
                    cadena = colorJugador2[contador2];
                    contador2 = contador2 + 1;
                }
                contadorG = contadorG + 1;
                Session["contadorG"] = contadorG;
                Session["contadorJ1"] = contador1;
                Session["contadorJ2"] = contador2;
                return cadena + "&" + contadorG;
            }
            catch{
                return "Ingrese los datos";
            }
        }

        public string Leer(string pruta, int conteo)
        {
            conteo = conteo - 1;
            string cadena = "0&No se completó la carga";
            Ficha = new List<string>();
            if (pruta == "")
            {
                cadena = "";
            }
            else
            {
                try
                {
                    XmlReader reader = XmlReader.Create(pruta);
                    string FilasTam = "";
                    string ColumnasTam = "";
                    List<string> colores1 = new List<string> { };
                    List<string> colores2 = new List<string> { };
                    string modalidad;
                    string color = "";
                    string columna = "";
                    int fila;
                    var variableAgregar = "";
                    string variableAg = "";
                    string toca = "";
                    string colorToca = "";
                    string colorestoca = "";
                    string direccion = "";
                    Boolean existe;
                    while (reader.Read())
                    {
                        if (reader.IsStartElement())
                        {
                            Ficha temp = new Ficha();
                            Personalizado temp2 = new Personalizado();
                            switch (reader.Name.ToString())
                            {
                                case "Partida":
                                    break;
                                case "filas":
                                    temp2.filas = reader.ReadString();
                                    FilasTam = temp2.filas;
                                    break;
                                case "columnas":
                                    temp2.columnas = reader.ReadString();
                                    ColumnasTam = temp2.columnas;
                                    break;
                                case "Jugador1":
                                    colorestoca = "1";
                                    break;
                                case "Jugador2":
                                    colorestoca = "2";
                                    break;
                                case "Modalidad":
                                    temp2.modalidad = reader.ReadString();
                                    modalidad = temp2.modalidad;
                                    if (modalidad == "Normal")
                                    {
                                        direccion = "ok";
                                    }
                                    else
                                    {
                                        return "El archivo no es para este módulo.";
                                    }
                                    break;
                                case "color":
                                    string colorIngles = reader.ReadString();
                                    switch (colorIngles)
                                    {
                                        case "rojo":
                                            colorIngles = "red";
                                            break;
                                        case "amarillo":
                                            colorIngles = "yellow";
                                            break;
                                        case "azul":
                                            colorIngles = "blue";
                                            break;
                                        case "anaranjado":
                                            colorIngles = "orange";
                                            break;
                                        case "verde":
                                            colorIngles = "green";
                                            break;
                                        case "violeta":
                                            colorIngles = "Violet";
                                            break;
                                        case "blanco":
                                            colorIngles = "white";
                                            break;
                                        case "negro":
                                            colorIngles = "black";
                                            break;
                                        case "celeste":
                                            colorIngles = "#00AAE4";
                                            break;
                                        case "gris":
                                            colorIngles = "Gray";
                                            break;
                                    }
                                    if (colorestoca == "1")
                                    {
                                        temp2.colores1 = colorIngles;
                                        color = temp2.colores1;
                                        colores1.Add(color);
                                    }
                                    if(colorestoca == "2")
                                    {
                                        temp2.colores2 = colorIngles;
                                        color = temp2.colores2;
                                        colores2.Add(color);
                                    }
                                    if (colorestoca == "3")
                                    {
                                        temp.color = colorIngles;
                                        color = temp.color;
                                        if (toca == "%")
                                        {
                                            colorToca = temp.color;
                                        }
                                    }
                                    break;
                                case "tablero":
                                    colorestoca = "3";
                                    break;
                                case "ficha":
                                    break;
                                case "columna":
                                    temp.columna = reader.ReadString();
                                    columna = temp.columna;
                                    break;
                                case "fila":
                                    temp.fila = reader.ReadElementContentAsInt();
                                    fila = temp.fila;
                                    variableAgregar = color + "," + columna + "" + fila;
                                    variableAg = variableAgregar.ToString();
                                    break;
                                case "siguienteTiro":
                                    toca = "%";
                                    break;
                            }

                            existe = Ficha.Contains(variableAg);
                            if (existe == true || variableAg == "" || toca == "%")
                            {
                                Console.WriteLine(" ");
                            }
                            else
                            {
                                Ficha.Add(variableAg);
                            }
                            if (toca == "%" && colorToca != "")
                            {
                                Ficha.Add("Turno," + colorToca);
                                toca = "";
                            }
                        }
                    }

                    cadena = FilasTam+"&"+ColumnasTam;
                    cadena = cadena + "|";
                    cadena = cadena + "" + colores1[0];
                    for (int i = 1; i < colores1.Count(); i++)
                    {
                        cadena = cadena + "&" +colores1[i];
                    }
                    cadena = cadena + "|";
                    cadena = cadena + "" + colores2[0];
                    for (int i = 1; i < colores2.Count(); i++)
                    {
                        cadena = cadena + "&" + colores2[i];
                    }
                    cadena = cadena + "|";
                    cadena = cadena + ""+Ficha[0];
                    int contar = 1;
                    while (contar != Ficha.Count())
                    {
                        if(contar == (Ficha.Count()-1))
                        {
                            cadena = cadena + "|" +Ficha[contar];
                        }
                        else
                        {
                        cadena = cadena + "&" + Ficha[contar];
                        }
                        contar++;
                    }

                    return cadena;
                }
                catch (Exception e)
                {
                    cadena = "";
                    return cadena;
                }
            }
            return cadena;
        
    }

        public string Leer2(string pruta, int conteo)
        {
            conteo = conteo - 1;
            string cadena = "0&No se completó la carga";
            Ficha = new List<string>();
            if (pruta == "")
            {
                cadena = "";
            }
            else
            {
                try
                {
                    XmlReader reader = XmlReader.Create(pruta);
                    string FilasTam = "";
                    string ColumnasTam = "";
                    List<string> colores1 = new List<string> { };
                    List<string> colores2 = new List<string> { };
                    string modalidad;
                    string color = "";
                    string columna = "";
                    int fila;
                    var variableAgregar = "";
                    string variableAg = "";
                    string toca = "";
                    string colorToca = "";
                    string colorestoca = "";
                    string direccion = "";
                    Boolean existe;
                    while (reader.Read())
                    {
                        if (reader.IsStartElement())
                        {
                            Ficha temp = new Ficha();
                            Personalizado temp2 = new Personalizado();
                            switch (reader.Name.ToString())
                            {
                                case "Partida":
                                    break;
                                case "filas":
                                    temp2.filas = reader.ReadString();
                                    FilasTam = temp2.filas;
                                    break;
                                case "columnas":
                                    temp2.columnas = reader.ReadString();
                                    ColumnasTam = temp2.columnas;
                                    break;
                                case "Jugador1":
                                    colorestoca = "1";
                                    break;
                                case "Jugador2":
                                    colorestoca = "2";
                                    break;
                                case "Modalidad":
                                    temp2.modalidad = reader.ReadString();
                                    modalidad = temp2.modalidad;
                                    if (modalidad == "Inverso")
                                    {
                                        direccion = "ok";
                                    }
                                    else
                                    {
                                        return "El archivo no es para este módulo.";
                                    }
                                    break;
                                case "color":
                                    string colorIngles = reader.ReadString();
                                    switch (colorIngles)
                                    {
                                        case "rojo":
                                            colorIngles = "red";
                                            break;
                                        case "amarillo":
                                            colorIngles = "yellow";
                                            break;
                                        case "azul":
                                            colorIngles = "blue";
                                            break;
                                        case "anaranjado":
                                            colorIngles = "orange";
                                            break;
                                        case "verde":
                                            colorIngles = "green";
                                            break;
                                        case "violeta":
                                            colorIngles = "Violet";
                                            break;
                                        case "blanco":
                                            colorIngles = "white";
                                            break;
                                        case "negro":
                                            colorIngles = "black";
                                            break;
                                        case "celeste":
                                            colorIngles = "#00AAE4";
                                            break;
                                        case "gris":
                                            colorIngles = "Gray";
                                            break;
                                    }
                                    if (colorestoca == "1")
                                    {
                                        temp2.colores1 = colorIngles;
                                        color = temp2.colores1;
                                        colores1.Add(color);
                                    }
                                    if (colorestoca == "2")
                                    {
                                        temp2.colores2 = colorIngles;
                                        color = temp2.colores2;
                                        colores2.Add(color);
                                    }
                                    if (colorestoca == "3")
                                    {
                                        temp.color = colorIngles;
                                        color = temp.color;
                                        if (toca == "%")
                                        {
                                            colorToca = temp.color;
                                        }
                                    }
                                    break;
                                case "tablero":
                                    colorestoca = "3";
                                    break;
                                case "ficha":
                                    break;
                                case "columna":
                                    temp.columna = reader.ReadString();
                                    columna = temp.columna;
                                    break;
                                case "fila":
                                    temp.fila = reader.ReadElementContentAsInt();
                                    fila = temp.fila;
                                    variableAgregar = color + "," + columna + "" + fila;
                                    variableAg = variableAgregar.ToString();
                                    break;
                                case "siguienteTiro":
                                    toca = "%";
                                    break;
                            }

                            existe = Ficha.Contains(variableAg);
                            if (existe == true || variableAg == "" || toca == "%")
                            {
                                Console.WriteLine(" ");
                            }
                            else
                            {
                                Ficha.Add(variableAg);
                            }
                            if (toca == "%" && colorToca != "")
                            {
                                Ficha.Add("Turno," + colorToca);
                                toca = "";
                            }
                        }
                    }

                    cadena = FilasTam + "&" + ColumnasTam;
                    cadena = cadena + "|";
                    cadena = cadena + "" + colores1[0];
                    for (int i = 1; i < colores1.Count(); i++)
                    {
                        cadena = cadena + "&" + colores1[i];
                    }
                    cadena = cadena + "|";
                    cadena = cadena + "" + colores2[0];
                    for (int i = 1; i < colores2.Count(); i++)
                    {
                        cadena = cadena + "&" + colores2[i];
                    }
                    cadena = cadena + "|";
                    cadena = cadena + "" + Ficha[0];
                    int contar = 1;
                    while (contar != Ficha.Count())
                    {
                        if (contar == (Ficha.Count() - 1))
                        {
                            cadena = cadena + "|" + Ficha[contar];
                        }
                        else
                        {
                            cadena = cadena + "&" + Ficha[contar];
                        }
                        contar++;
                    }

                    return cadena;
                }
                catch (Exception e)
                {
                    cadena = "";
                    return cadena;
                }
            }
            return cadena;

        }

        public string Conteo()
        {
            string cadena = "";
            int cuenta = (int)Session["contar"];
            cuenta = cuenta + 1;
            Session["contar"] = cuenta;
            return cadena+"&"+cuenta;
        }
    }
}