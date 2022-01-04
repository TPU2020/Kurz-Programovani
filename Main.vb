Module Main
#Region "Hlavní funkce"
    Sub Main()
        Dim modul As String, opakovat As Char
        Do
            Console.Clear()
            Console.WriteLine("Vyberte modul, který chcete spustit...")
            modul = Console.ReadLine()
            modul = LCase(modul)

            Select Case modul
                Case "c1"
                    C1()
                Case "c2"
                    C2()
                Case "c3"
                    C3()
                Case "c4"
                    C4()
                Case "c5"
                    C5()
                Case "c6"
                    C6()
                Case "c7"
                    C7()
                Case "c8"
                    C8()
                Case "c9"
                    C9()
                Case "c10"
                    C10()
                Case "c11"
                    C11()
                Case "d1"
                    D1()
                Case "d2"
                    D2()
                Case "d3"
                    D3()
                Case "d4"
                    D4()
                Case "d5"
                    D5()
                Case "d6"
                    D6()
                Case "d7"
                    D7()
                Case "d8"
                    D8()
                Case "d9"
                    D9()
                Case "d10"
                    D10()
                Case "e1"
                    E1()
                Case "e2"
                    E2()
                Case "e3"
                    E3()
                Case "e4"
                    E4()
                Case "e5"
                    E5()
                Case "e6"
                    E6()
                Case "e7"
                    E7()
                Case "e8"
                    E8()
                Case "f1"
                    F1()
                Case "f2"
                    F2()
                Case "f3"
                    F3()
                Case "f4"
                    F4()
                Case "f5"
                    F5()
                Case "f6"
                    F6()
                Case "f7"
                    F7()
                Case Else
                    Console.WriteLine("Neznámý modul")
            End Select

            Console.WriteLine(vbNewLine + "Konec programu..." + vbNewLine + vbNewLine + "Pro opakování stiskněte libovolnou klávesu, pro ukončení programu stiskněte (n)")
            opakovat = Console.ReadKey.KeyChar()
        Loop Until opakovat = "n"

    End Sub
#End Region

#Region "Příklad C1"
    'Vypište tabulku x funkce sinus(x) pro x od 0 do 2*PI s krokem 0,1. Výpis bude vypadat např. takto:
    'sin(0, 0) = 0
    'sin(0, 1) = 0,0998
    'atd.
    'Nevadí, když místo 0, 998 bude , 998
    Sub C1()

        Dim vysledek As Double

        For i = 0 To 2 * Math.PI Step 0.1
            vysledek = Math.Sin(i)

            Console.WriteLine(Format(vysledek, "0.0000"))
        Next

    End Sub
#End Region

#Region "Příklad C2"
    'Program vygeneruje deset náhodných celých čísel (např. od -90 do 100). Zjistěte, kolik z nich je v určitém intervalu (např. od 10 do 50) 
    'S algoritmizací tohoto programu si někteří účastníci nevědí rady. Pokud je To i váš případ, tak příklad zkuste nejprve vyřešit bez počítače.
    'Vezměte deset malých papírků na poznámky a napište na ně náhodně čísla od -90 Do +100. Nachystejte si i papír, který nadepíšete např. pocetCiselVIntervalu.
    'Potom vezměte první papírek, přečtěte jej, a pokud je v rozsahu mezi 10 a 50, pak na papír nadepsaný pocetCiselVIntervalu napíšete čárku.
    'Toto proveďte 10x (tedy na jiný papír, nazvaný index, si děláte čárky a až jich bude 10, tak skončíte).
    'Poté slavnostně oznamte, kolik máte čárek na papíru pocetCiselVIntervalu. A pak to zkuste zapsat ve Visual Basicu. Vlastně stačí následující popis převést do angličtiny
    'Následující činnost proveď 10x (tedy zvyšuj při každém průchodu hodnotu proměnné index od 1 do 10)
    'načtěte do proměnné (papírku) náhodné číslo v rozsahu <-90, 100>
    'pokud je proměnná v rozsahu mezi 10 a 50, pak zvýšíte hodnotu proměnné pocetCiselVIntervalu o jedničku
    'konec opakované činnosti
    'oznamte hodnotu proměnné pocetCiselVIntervalu
    Sub C2()

        Dim i, rnd_no As Integer, s As String
        Dim pocetCiselVIntervalu As Byte
        s = "Náhodná čísla v intervalu <-90,100> jsou: "
        For i = 0 To 10
            rnd_no = Int(Rnd() * 190) - 90
            s = s + Str(rnd_no) + “, “
            If rnd_no >= 10 And rnd_no <= 50 Then
                pocetCiselVIntervalu += 1
            End If
        Next

        Console.WriteLine(s + vbNewLine + "Počet čísel v intervalu <10,50> je " + Str(pocetCiselVIntervalu))

    End Sub
#End Region

#Region "Příklad C3"
    'Vytvořte program, který táhne 5 čísel Sportky (čísla 1 až 49). Čísla se (na rozdíl od Sportky) mohou opakovat.
    Sub C3()

        Dim i, rnd_no As Integer, s As String

        s = "Čísla Sportky jsou: "
        For i = 1 To 5
            rnd_no = Int(Rnd() * 48) + 1
            s = s + Str(rnd_no) + “, “
        Next
        Console.WriteLine(s)

    End Sub
#End Region

#Region "Příklad C4"
    'Vypište klesající posloupnost čísel od 8 do -8.  Varianta: vypište stejnou posloupnost, ale pouze každé druhé (sudé) číslo. (Nepoužívejte if.)
    Sub C4()

        Dim i As Integer

        For i = 8 To -8 Step -1
            Console.WriteLine(i)
        Next

        For i = 8 To -8 Step -2
            Console.WriteLine(i)
        Next

    End Sub
#End Region

#Region "Příklad C5"
    'Vygenerujte 20 celých náhodných celých čísel v rozsahu 10..50. Zjistěte, o kolik se jejich střední hodnota (průměr) liší od středu intervalu, tedy od 30.

    Sub C5()

        Dim i, rnd_no, strednihodnota, rozdil As Integer, s As String

        s = "Náhodná jsou: "
        For i = 1 To 20
            rnd_no = Int(Rnd() * 40) + 10
            s = s + Str(rnd_no) + “, “
            strednihodnota += rnd_no
        Next

        strednihodnota = strednihodnota / 20
        rozdil = Math.Abs(strednihodnota - 30)
        Console.WriteLine(s + vbNewLine + "Rozdíl střední hodnoty se od středu intervalu <10,50> liší o " + Str(rozdil))

    End Sub
#End Region

#Region "Příklad C6"
    'Zadejte, kolik je tříd ve škole.
    'Potom postupně zadávejte, kolik je v každé třídě žáků.
    'Program spočítá, kolik je žáků v celé škole a průměrný počet žáků ve třídě. (obdoba d1)

    Sub C6()

        Dim i, pocettrid, pocetzaku As Double

        Console.WriteLine("Zadejte počet tříd...")
        pocettrid = Convert.ToDouble(Console.ReadLine())

        For i = 1 To pocettrid
            Console.WriteLine("Zadejte počet počet žáků v " + Str(i) + ". třídě")
            pocetzaku += Convert.ToDouble(Console.ReadLine())
        Next

        Console.WriteLine("Počet žáků v celé škole je " + Str(pocetzaku) + vbNewLine + "A průměrný počet žáků ve třídě je " + Str(pocetzaku / pocettrid))

    End Sub
#End Region

#Region "Příklad C7"
    'Nasimulujte minutu po minutě kurz koruny k euru prvních dvacet minut po opuštění kurzového závazku ČNB.
    'Bude oscilovat mezi 26 (včetně) a 28 (ne včetně) Kč/Euro.
    'V MsgBoxu je vypište (pomocí Mod)  tak, že budou vždy po pěti na řádku (oddělené tabulátorem či čárkou nebo mezerou).
    'Vypište s dvěma desetinnými čísly.
    Sub C7()

        Dim i As Byte, kurz As Decimal, s As String

        s = "Kurz (Kč/Euro):" + vbNewLine

        For i = 1 To 20
            kurz = CDec(Rnd() * 2) + 26
            s = s + Format(kurz, "0.00") + “    “
            If i Mod 5 = 0 Then
                s += vbNewLine
            End If
        Next
        Console.WriteLine(s)

    End Sub
#End Region

#Region "Příklad C8"
    'Zadej celé kladné číslo a pak program vypíše součet celých čísel od jedné do udaného čísla

    Sub C8()
        Dim i, cislo, soucetcisel As Double

        Console.WriteLine("Zadejte celé kladné číslo...")
        cislo = Convert.ToDouble(Console.ReadLine())

        For i = 1 To cislo
            soucetcisel += i
        Next

        Console.WriteLine("Součet čísel od 1 do " + Str(cislo) + " je " + Str(soucetcisel))

    End Sub
#End Region

#Region "Příklad C9"
    'Zadejte z klávesnice celé kladné číslo větší než dvě, program vypíše všechny jeho dělitele, nepočítaje 1 a sebe sama (použij operátor modulo).
    'Pokud žádný není, oznámí, že se jedná o prvočíslo.
    'Pro kontrolu u čísla 12 jsou dělitele čísla: 2, 3, 4, 6. A číslo 13 je prvočíslo.
    'Pozn.: dělitel nějakého čísla, je takové číslo, kterým je možno dělit beze zbytku.
    'Takže trojka je dělitelem čísla 12, protože se do něj vejde přesně čtyřikrát.
    'Zatímco pětka není dělitele čísla 12, protože se tam vejde dvakrát, ale zůstane zbytek 2.
    'Nápověda: Je třeba ve smyčce spočítat počet dělitelů (tedy při každém nalezení dělitele zvýšit toto počitadlo o jedničku).
    'A po smyčce zjistit, zda je počet nulový: v tom případě se jedná o prvočíslo. 
    Sub C9()

        Dim i, cislo, pocetdelitelu As Double, s As String
        s = ""


        Console.WriteLine("Zadejte celé kladné číslo větší než 2...")

        cislo = Convert.ToDouble(Console.ReadLine())
        If cislo > 2 Then
            For i = 2 To cislo - 1
                If cislo Mod i = 0 Then
                    pocetdelitelu += 1
                    s += Str(i)
                End If
            Next
        Else
            Console.WriteLine("Číslo není větší než 2!!!")
        End If

        If pocetdelitelu = 0 Then
            Console.WriteLine(Format(cislo) + " je prvočíslo ")
        Else
            Console.WriteLine("Počet dělitelů čísla" + Format(cislo) + " je " + Format(pocetdelitelu) + vbNewLine + s)
        End If


    End Sub
#End Region

#Region "Příklad C10"
    'Vytvořte program pro zkoušení malé násobilky.
    'Program zadává náhodně násobení čísel od 1 do 10, např. 5*6=, 8*4= atd. Uživatel napíše výsledek.
    'Pokud to je špatně, napíše počítač správný výsledek.
    'Celkem 10 příkladů, nakonec se zobrazí počet chyb.
    Sub C10()

        Dim c1, c2, c, vysledek As Integer

        For i = 1 To 10
            c1 = Int(Rnd() * 9) + 1
            c2 = Int(Rnd() * 9) + 1
            c = c1 * c2
            Console.WriteLine(Format(c1) + "*" + Format(c2) + "=?")
            vysledek = Convert.ToInt32(Console.ReadLine())
            If vysledek <> c Then
                Console.WriteLine("Správný výsledek je: " + Format(c))
            End If
        Next

    End Sub
#End Region

#Region "Příklad C11"
    'Tabulka ASCII: zobrazit v  MsgBoxu v levém sloupci čísla např. 65 až 100 a v pravém příslušný znak.

    Sub C11()
        Dim s As String
        s = ""

        For i = 65 To 122
            s += Format(i) + " = " + Convert.ToChar(i) + vbNewLine

        Next

        MsgBox(s)

    End Sub
#End Region

#Region "Příklad D1"
    'Zadejte postupně, kolik je v každé třídě žáků (0=konec).
    'Program spočítá, kolik je žáků v celé škole a průměrný počet žáků ve třídě.
    'Ověřte, že nula do platných dat nepatří.
    'Nesmí se tedy stát, že při zadání 30 a 0 (tedy jen jedna třída a to s 30 žáky) vyjde průměrný počet žáků 15 (omylem se uvažovaly dvě třídy, jedna má 30 a druhá 0 žáků)

    Sub D1()

        Dim celkemzaku, pocetzaku, pocettrid As Double

        Do
            pocettrid += 1
            Console.WriteLine("Zadejte počet žáků v " + Format(pocettrid) + ". třídě")
            pocetzaku = Convert.ToDouble(Console.ReadLine())
            celkemzaku += pocetzaku
        Loop Until (pocetzaku = 0)

        Console.WriteLine("Celkový počet žáků je " + Format(celkemzaku) + " a průměrný počet žáků ve třídě je " + Format(celkemzaku / pocettrid, "0.0"))

    End Sub
#End Region

#Region "Příklad D2"
    'Máte schované účtenky z různých nákupů, nevíte ale, kolik účtenek je.
    'Proto částky na účtenkách budete zadávat postupně, jako poslední zadáte nulu.
    'Program spočítá, kolik jste utratili a zároveň oznámí, kolik nákupů přesáhlo částku 100 Kč.

    Sub D2()
        Dim celkemutrata, utrata, pocetuctenek, pocetucteneknad100 As Double

        Do
            pocetuctenek += 1
            Console.WriteLine("Zadejte částku na " + Format(pocetuctenek) + ". účtence")
            utrata = Convert.ToDouble(Console.ReadLine())
            celkemutrata += utrata
            If utrata > 100 Then
                pocetucteneknad100 += 1
            End If

        Loop Until (utrata = 0)

        Console.WriteLine("Celková útrata je " + Format(celkemutrata) + " a počet účtenek nad 100 Kč je " + Format(pocetucteneknad100))

    End Sub
#End Region

#Region "Příklad D3"
    'Zadejte první, druhy a poslední člen lineární celočíselné posloupnosti (lineární posloupnost je taková, kde mezi jednotlivými členy jsou stejné odstupy, např. 12, 15, 18, 21...).
    'Program zobrazí pod sebou všechny prvky posloupnosti. 
    'Pozn.: program musí fungovat, i kdyby třetí zadané číslo se nestrefilo do členů posloupnosti (tedy kdyby toto číslo nebylo v posloupnosti obsaženo).
    'Takže je to třeba chápat spíše tak, že třetí zadané číslo je limit.
    'Varianta: Zadá se první a druhy krok a počet prvku posloupnosti.

    Sub D3()
        Dim c1, c2, c3, hodnota As Double, s As String

        Console.WriteLine("Zadejte první číslo posloupnosti")
        c1 = Convert.ToDouble(Console.ReadLine())
        Console.WriteLine("Zadejte druhé číslo posloupnosti")
        c2 = Convert.ToDouble(Console.ReadLine())
        Console.WriteLine("Zadejte třetí poslední posloupnosti")
        c3 = Convert.ToDouble(Console.ReadLine())

        hodnota = Math.Min(c1, c2)
        s = ""

        Do While (c3 >= hodnota)
            s += " " + Format(hodnota)
            hodnota += Math.Abs(c1 - c2)
        Loop

        Console.WriteLine(s)

    End Sub
#End Region

#Region "Příklad D4"
    'Varianta na b5): Program postupně čte nejprve jméno a pak výšku žáka.
    'Prázdné jméno načítání ukončuje.
    'Poté zobrazí jméno a výšku nejvyššího žáka.
    'Když jsou nejvyšší dva a více stejně vysocí, napíše jen jednoho.
    'Bude zdokonaleno později v sekci e) v BasicCv_těžší

    Sub D4()
        Dim jmeno, jmenonejvyssi As String, vyska, vyskanejvyssi As Integer, pocetzaku As Byte

        jmenonejvyssi = ""

        Do
            pocetzaku += 1
            Console.WriteLine("Zadejte jméno " + Format(pocetzaku) + ". žáka")
            jmeno = Console.ReadLine()
            If jmeno = "" Then Exit Do

            Console.WriteLine("Zadejte výšku žáka " + jmeno)
            vyska = Convert.ToInt32(Console.ReadLine())
            If vyska > vyskanejvyssi Then
                vyskanejvyssi = vyska
                jmenonejvyssi = jmeno
            End If
        Loop

        Console.WriteLine("Jméno nejvyššího žáka je " + jmenonejvyssi + " a jeho výška je " + Format(vyskanejvyssi))

    End Sub
#End Region

#Region "Příklad D5"
    'Zadejte několik celých čísel, ukončete nulou (ta již do dat nepatří).
    'Program v MsgBoxu vypíše daná čísla, jejich počet, součet, průměr, minimum, maximum.
    'Případně ještě vypíše ta z nich, která jsou sudá a jejich počet.
    'Případně ještě vypíše ta z nich, která jsou větší, než první číslo.

    Sub D5()
        Dim cislo, pocetcelkem, soucet, prumer, minimum, maximum, pocetsuda, prvni As Double, ssuda, s, vetsinezprvni As String

        s = ""
        ssuda = ""
        minimum = Double.MaxValue
        maximum = Double.MinValue
        vetsinezprvni = ""

        Console.WriteLine("Zadejte postupně celá čísla - pro ukončení vložte 0")

        Do
            cislo = Convert.ToDouble(Console.ReadLine())
            If cislo = 0 Then Exit Do
            If pocetcelkem = 0 Then prvni = cislo

            s += " " + Format(cislo)
            pocetcelkem += 1
            soucet += cislo
            prumer = pocetcelkem / soucet

            minimum = Math.Min(minimum, cislo)
            maximum = Math.Max(maximum, cislo)
            If cislo Mod 2 = 0 Then
                pocetsuda += 1
                ssuda += " " + Format(cislo)
            End If

            If cislo > prvni Then vetsinezprvni += " " + Format(cislo)

        Loop

        MsgBox("Čísla řady: " + s + vbNewLine +
               "Počet je " + Format(pocetcelkem) + vbNewLine +
               "Součet je " + Format(soucet) + vbNewLine +
               "Průměr je " + Format(prumer) + vbNewLine +
               "Minimun je " + Format(minimum) + vbNewLine +
               "Maximum je " + Format(maximum) + vbNewLine +
               "Sudá čísla: " + ssuda + vbNewLine +
               "Počet sudých je " + Format(pocetsuda) + vbNewLine +
               "Čísla větší než první zadané číslo " + vetsinezprvni)
    End Sub
#End Region

#Region "Příklad D6"
    'Upraveno podle Doc. Homoly: Sestavte program, který si myslí (náhodně vygeneruje) celé číslo z intervalu <1,10>.
    'Pak ho vy hádáte (zadáváte z klávesnice), dokud se nestrefíte.
    'Počítač vypíše, na který pokus se to podařilo.

    Sub D6()
        Dim cislo, pokus, nahodne As Integer

        Console.WriteLine("Uhodněte celé číslo z intervalu <1,10>")
        nahodne = Int(Rnd() * 10 + 1)
        Do
            pokus += 1
            cislo = Convert.ToInt32(Console.ReadLine())

        Loop Until (nahodne = cislo)

        Console.WriteLine("Uhádnuto na " + Format(pokus) + ". pokus")

    End Sub
#End Region

#Region "Příklad D7"
    'Program hází kostkou tak dlouho, dokud nepadne šestka.
    'Potom vypíše, kolik hodů bylo potřeba.

    Sub D7()
        Dim cislo, pokus As Integer

        Do
            cislo = Int(Rnd() * 6 + 1)
            pokus += 1
            Console.WriteLine("Hod..." + Format(cislo))

        Loop Until (cislo = 6)

        Console.WriteLine("Kostkou bylo hozeno " + Format(pokus) + " krát")
    End Sub
#End Region

#Region "Příklad D8"
    'Varianta příkladu ze skupiny b: Uživatel opakovaně zadá znak, program vždy odpoví, zda se jedná o písmeno, číslici nebo jiný znak.
    'Zadávání končí zadáním např. nuly (nebo to pro změnu zkuste ukončit nějakým jiným znakem).
    'Řešte pomocí else if.

    Sub D8()
        Dim znak As Byte

        Do
            Console.WriteLine("Zadejte znak - pro ukončení zadejte #")
            znak = Asc(Console.ReadLine())

            If znak >= 48 And znak <= 57 Then
                Console.WriteLine("Číslice")
            ElseIf znak >= 65 And znak <= 90 Then
                Console.WriteLine("Velké písmeno")
            ElseIf znak >= 97 And znak <= 122 Then
                Console.WriteLine("Malé písmeno")
            Else
                Console.WriteLine("Jiný znak")
            End If
        Loop Until (znak = 35)

    End Sub
#End Region

#Region "Příklad D9"
    'Uživatel bude zadávat postupně teploty vody s přesností na desetinu stupně.
    'Zadávání ukončí zadáním teploty přesahující 100° (tato teplota je ale také součástí dat!).
    'Zadávání končí, protože pak už voda vyvřela.
    'Program zobrazí zadané teploty, minimální teplotu a kolikátá v pořadí tato teplota byla.
    'A také průměr teplot

    Sub D9()
        Dim teplota, teplotaMin, teplotaAvg As Decimal, pozice, pocet As Integer, s As String

        s = ""
        teplotaMin = Decimal.MaxValue

        Console.WriteLine("Zadejte postupně teplotu vody než vyvře")

        Do
            teplota = Convert.ToDecimal(Console.ReadLine())
            pocet += 1
            teplotaAvg += teplota
            s += " " + Format(teplota, "0.0°C")
            If teplota < teplotaMin Then
                teplotaMin = teplota
                pozice = pocet
            End If

        Loop While (teplota < 100)

        Console.WriteLine("Voda vyvřela..." + vbNewLine +
            "Zadané teploty" + vbNewLine + s + vbNewLine +
            "Minimální teplota: " + Format(teplotaMin) + "°C a pozice minimální teploty je " + Format(pozice))

    End Sub
#End Region

#Region "Příklad D10"
    Sub D10()
        'Vyzkoušejte všechny příklady c) s použitím  WHILE.

    End Sub
#End Region

#Region "Příklad E1"
    'Zadejte řadu čísel ukončenou nulou.
    'Zjistěte nejmenší a vypište, kolikrát se v řadě opakuje.
    '(návod: v druhé smyčce se najde minimum. A tentokrát bude i smyčka třetí, ve které se zjistí, kolikrát se v poli toto minimum vyskytuje).
    'Pozn.: lze řešit i dvěma smyčkami, první a druhá se spojí Do jedné.
    'Tedy čísla se zadávají a hned se zjišťuje, zdali není menší, než dosavadní minimum.
    'Pozn.: šlo by To i jednou smyčkou, ale to už je náročnější. A nebylo by v tom případě nutné pole.
    Sub E1()

        Dim cislo, index, opakovani, nejmensi As Byte, pole(99) As Byte, rada As String
        rada = "" : index = 0 : nejmensi = Byte.MaxValue : opakovani = 0

        Console.WriteLine("Zadejte čísla, nulou ukončíte zadávání")

        Do
            cislo = Convert.ToByte(Console.ReadLine)
            If cislo = 0 Then Exit Do
            pole(index) = cislo
            rada = rada + Str(cislo)
            index += 1
        Loop

        For j = 0 To index - 1
            If nejmensi >= pole(j) Then
                nejmensi = pole(j)
            End If
        Next

        For k = 0 To index - 1
            If nejmensi = pole(k) Then
                opakovani += 1
            End If
        Next

        Console.WriteLine("Zadaná čísla " + rada)
        Console.WriteLine("Nejmenší číslo řady je " + Format(nejmensi) + " a počet jeho opakování je " + Format(opakovani))

    End Sub
#End Region

#Region "Příklad E2"
    'Zadejte několik čísel, ukončete nulou.
    'Potom zadáte některé z předtím zadaných čísel.
    'Program vypíše, kolikrát toto číslo předtím padlo.
    Sub E2()


        Dim cislo, index, opakovani, zvolene As Byte, pole(99) As Byte, rada As String
        rada = "" : index = 0 : opakovani = 0

        Console.WriteLine("Zadejte čísla, nulou ukončíte zadávání")

        Do
            cislo = Convert.ToByte(Console.ReadLine)
            If cislo = 0 Then Exit Do
            pole(index) = cislo
            rada = rada + Str(cislo)
            index += 1
        Loop

        Console.WriteLine("Zadejte jedno předchozích čísel")
        zvolene = Convert.ToByte(Console.ReadLine)

        For k = 0 To index - 1
            If zvolene = pole(k) Then
                opakovani += 1
            End If
        Next

        Console.WriteLine("Zadaná čísla " + rada)
        Console.WriteLine("Zvolené číslo řady je " + Format(zvolene) + " a počet jeho opakování je " + Format(opakovani))

    End Sub
#End Region

#Region "Příklad E3"
    'Vygenerujte několik hodů kostkou. Program vypíše, kolikrát padla jednotlivá čísla a vyjádří procentuálně.
    'Jaký byl průměr? Návod: Dá se to udělat např. tak, že si deklaruji šest počitadel, např. pocet1, pocet2 až pocet6.
    'A v druhé smyčce bude struktura If-Else s šesti větvemi kde se bude zvyšovat o jedničku počitadlo pocet1 nebo pocet2 atd.
    'Pro kontrolu: jejich součet musí být roven počtu hodů.
    'Až to bude chodit, tak místo šesti proměnných pocet1 až pocet6 použít pole (nazvané např. pocty).
    'Tedy jedná se o další pole. V jednom poli jsou všechny hody a v druhém poli je šest čísel s počtem četností jednotlivých hodnot.
    'Druhá varianta: ověřte, že při zaokrouhlování pomocí Round padají krajní čísla (1 a 6) s poloviční četností.
    'Přitom Int pracoval správně, všechny hodnoty mají kolem 100/6=16,6 %.
    Sub E3()

        Dim opakovani(5), hodnoty(99) As Byte

        Console.WriteLine("Házím kostkou...")

        For i = 0 To 99
            hodnoty(i) = Int(Rnd() * 6 + 1)

            Select Case hodnoty(i)
                Case 1
                    opakovani(0) += 1
                Case 2
                    opakovani(1) += 1
                Case 3
                    opakovani(2) += 1
                Case 4
                    opakovani(3) += 1
                Case 5
                    opakovani(4) += 1
                Case 6
                    opakovani(5) += 1
                Case Else
                    Console.WriteLine("Chyba ...")
            End Select
        Next

        Console.WriteLine("Hody kostkou" + vbNewLine + String.Join(" ", hodnoty))
        Console.WriteLine("Opakování jednotlivých čísel" + vbNewLine _
            + "1(" + Format(opakovani(0)) + ") " _
            + "2(" + Format(opakovani(1)) + ") " _
            + "3(" + Format(opakovani(2)) + ") " _
            + "4(" + Format(opakovani(3)) + ") " _
            + "5(" + Format(opakovani(4)) + ") " _
            + "6(" + Format(opakovani(5)) + ") ")
    End Sub
#End Region

#Region "Příklad E4"
    'Upravte program pro Sportku (c3) tak, aby se tažená čísla nemohla opakovat. Testujte na větším počtu tahů, aby se opakování projevilo.
    'Ještě lépe se projeví, pokud budete testovat na hodech kostkou (1-6), také nemá padnout stejné číslo dvakrát.
    'Srovnejte s e2): tam se zjišťuje, kolikrát které číslo padlo.
    'A nyní se má zajistit, aby vícekrát nepadlo.
    'Pokud padne, hod se opakuje.
    'Tento program je dost obtížný.
    'Pokud zabere neúměrně hodně času, tak jej nechte až na druhou etapu přípravy, tedy po prvním vstupním testu.
    Sub E4()

        Dim hodnoty(9) As Boolean, cislo, pocet As Byte, opakovani As Long
        pocet = 0

        For Each element As Boolean In hodnoty
            element = False
        Next

        Do
            cislo = Int(Rnd() * 10)
            If hodnoty(cislo) = False Then
                hodnoty(cislo) = True
                pocet += 1
            End If
            opakovani += 1
        Loop Until (pocet = 10)

        Console.WriteLine("Pocet opakování pro naplnění všech 10 hodnot je" + Str(opakovani))
    End Sub
#End Region

#Region "Příklad E5"
    'Zadejte v jednom cyklu řadu čísel.
    'V dalších cyklech program poté spočítá jejich součet, průměr, maximum, minimum.
    'Pak se program ještě zeptá, zda chcete zobrazit součet druhých mocnin.
    Sub E5()

        Dim cislo, index, nejmensi, nejvetsi, soucet, pole(99) As Integer, prumer As Decimal, rada As String
        index = 0 : nejmensi = Integer.MaxValue : nejvetsi = Integer.MinValue : rada = ""

        Console.WriteLine("Zadejte čísla, nulou ukončíte zadávání")

        Do
            cislo = Convert.ToByte(Console.ReadLine)
            If cislo = 0 Then Exit Do
            pole(index) = cislo
            rada = rada + Str(cislo)
            index += 1
        Loop

        For i = 0 To index - 1
            If nejmensi > pole(i) Then
                nejmensi = pole(i)
            End If
            If nejvetsi < pole(i) Then
                nejvetsi = pole(i)
            End If
            soucet += pole(i)

        Next
        prumer = soucet / index - 1


        Console.WriteLine(rada)
        Console.WriteLine("Nejmenší" + Str(nejmensi) + vbNewLine +
                          "Největší" + Str(nejvetsi) + vbNewLine +
                          "Součet" + Str(soucet) + vbNewLine +
                          "Průměr" + Format(prumer, " 0.00"))

    End Sub
#End Region

#Region "Příklad E6"
    'Zadejte postupně několik písmen. Program potom náhodně vygeneruje slovo (shluk písmen), které se bude skládat z těchto písmen (např. vždy 5 znaků).
    'Písmena se mohou opakovat a nemusí být použita všechna.
    'Pozn. zadávání můžete ukončit třeba číslem 0 nebo třeba stiskem klávesy enter. (Varianta: vygenerujte třeba 10 slov.)
    'Varianta: Místo zadání z klávesnice vygeneruje prvotních několik písmen počítač.

    Sub E6()
        Dim znaky(4) As Char, slova(9) As String, cisloRnd As New Random

        For i = 0 To 4
            znaky(i) = Convert.ToChar(cisloRnd.Next(65, 90))
        Next

        Console.WriteLine("Vygenerované znaky " + znaky)

        For i = 0 To 9
            For j = 0 To 9
                slova(i) += znaky(cisloRnd.Next(0, 4))
            Next
        Next

        Console.WriteLine("Vygenerované slova " + vbNewLine + String.Join(vbNewLine, slova))

    End Sub
#End Region

#Region "Příklad E7"
    'Zadejte postupně do pole několik různých slov.
    'Každé slovo přitom budete zadávat zvlášť.
    'Poté znovu zadejte jedno z těchto slov.
    'Program vypíše číslo pořadí, v jakém bylo toto slovo zadáno (na jaké pozici se vyskytuje v poli).

    Sub E7()

        Dim slova(9), hledaneSlovo As String, index, poradiSlova As Byte
        index = 0 : poradiSlova = 1

        Console.WriteLine("Zadejte slova " + vbNewLine)

        Do
            slova(index) = Console.ReadLine
            If slova(index) = vbNullString Then Exit Do
            index += 1
        Loop Until slova(9) IsNot vbNullString

        Console.WriteLine(vbNewLine + "Vygenerované slova " + vbNewLine + String.Join(vbNewLine, slova))

        Console.WriteLine(vbNewLine + "Zadejte hledané slovo " + vbNewLine)
        hledaneSlovo = Console.ReadLine

        For Each slovo In slova
            If hledaneSlovo = slovo Then Exit For
            poradiSlova += 1
        Next

        Console.WriteLine(vbNewLine + "Pořadí hledaného slova " + hledaneSlovo + " je " + Format(poradiSlova, ""))

    End Sub
#End Region

#Region "Příklad E8"
    'Řadu slov z předchozího příkladu vypište v obráceném pořadí, a pak vypíše pouze sudá a pak pouze lichá slova.
    'A předělejte příklady c) a d) na pole.
    'Tedy nezpracovávejte je v první smyčce, ale až v druhé.

    Sub E8()

        Dim slova(9) As String, index As Byte
        index = 0

        Console.WriteLine("Zadejte slova " + vbNewLine)

        Do
            slova(index) = Console.ReadLine
            If slova(index) = vbNullString Then Exit Do
            index += 1
        Loop Until slova(9) IsNot vbNullString

        Console.WriteLine(vbNewLine)
        Console.WriteLine("Vygenerované slova v obráceném pořadí ")

        For i = 9 To 0 Step -1
            Console.WriteLine(slova(i))
        Next

        Console.WriteLine(vbNewLine)
        Console.WriteLine("Pouze sudá slova ")

        For i = 9 To 0 Step -2
            Console.WriteLine(slova(i))
        Next

        Console.WriteLine(vbNewLine)
        Console.WriteLine("Pouze lichá slova ")

        For i = 8 To 0 Step -2
            Console.WriteLine(slova(i))
        Next

    End Sub
#End Region

#Region "Příklad F1"
    'Napište funkci, která převádí stupně a minuty na radiány.
    'Proměnné se předávají přes parametry podprogramu, v hlavním programu použijte jiné názvy proměnných než v podprogramu.
    'Návod: řešte trojčlenkou.
    'Plnému kruhu odpovídá 360 stupňů nebo 2 pí radiánů (přibližně 6,28 radiánů).

    Sub F1()
        Dim uhel, rad As Single

        Console.WriteLine("Zadejte úhel v (deg,min) pro převod na (rad)")
        uhel = Convert.ToSingle(Console.ReadLine())

        rad = VypocetUhlu(uhel)
        Console.WriteLine(Format(uhel, "0.000") + " ° je " + Format(rad, "0.00") + " rad")

    End Sub
    Private Function VypocetUhlu(uhel As Single) As Single
        Return (uhel * (Math.PI / 180))
    End Function
#End Region

#Region "Příklad F2"
    'Napište funkci, které se zadá znak a která vrátí jeho ASCII hodnotu.  (příliš lehké)

    Sub F2()

        Dim znak As Char, znakASCII As Byte

        Console.WriteLine("Stiskněte na klávesnici znak pro převod do ASCII")
        znak = Console.ReadKey().KeyChar

        znakASCII = PrevodASCII(znak)
        Console.WriteLine(vbNewLine + "Znak " + znak + " je v ASCII číslo " + Format(znakASCII))

    End Sub

    Private Function PrevodASCII(znak As Char) As Integer
        Return Asc(znak)
    End Function

#End Region

#Region "Příklad F3"
    'Napište šifrovací funkci, které se předá písmeno a která vrátí následující písmeno v anglické abecedě.
    'Tedy znak, jehož pozice v ASCII tabulce je o jedno vyšší S jedinou výjimkou: pro „z“ vrátí „a“.
    'Poté program zdokonalte tak, aby se funkci předalo i číslo n a funkce pak v ASCII tabulce posouvá o n pozic.
    'Tedy například pro n=2 převede: a->c, y->a, z->b

    Sub F3()
        Dim znak, znakSifra As Char, n As Byte

        n = 2

        Console.WriteLine("Zadejte znak pro převod pomocí šifrovací funkce")
        znak = Chr(Console.Read())

        znakSifra = Sifra(znak, n)

        Console.WriteLine("Znak " + znak + " po převodu pomocí šifrovací funkce je " + znakSifra)

    End Sub

    Function Sifra(znak As Char, n As Byte) As Char
        Dim znakASCII As Byte

        znakASCII = Asc(znak)

        If znakASCII = 90 Or znakASCII = 122 And n >= 1 Then
            znakASCII -= 24
        End If

        znakASCII += n

        Return Chr(znakASCII)
    End Function

#End Region

#Region "Příklad F4"
    'Napište funkci, které se předá rok (čtyřciferný) a která vrací logickou hodnotu „True“, pokud je rok přestupný (má 366 dní místo 365).
    'Pro jednoduchost stačí řešit podle Juliánského kalendáře (gregoriánský bude za úkol později).
    'Potřebná teorie: Podle Juliánského kalendáře jsou přestupné roky ty, které jsou dělitelné čtyřmi 
    'Modifikace programu: funkce, která místo True-False bude vracet přímo délku roku (tedy 365 nebo 366)

    Sub F4()
        Dim rok, rokDelka As Integer

        Console.WriteLine("Zadejte rok pro kontrolu přestupného roku")
        rok = Convert.ToInt32(Console.ReadLine())

        rokDelka = PrestupnyRok(rok)

        If rokDelka = 366 Then
            Console.WriteLine("Zadaný rok je přestupný")
        Else
            Console.WriteLine("Zadaný rok není přestupný")
        End If

    End Sub

    Function PrestupnyRok(ByRef rok As Integer) As Integer
        Dim zbytek As Byte

        zbytek = rok Mod 4

        If zbytek = 0 Then
            Return 366
        End If

        Return 365
    End Function

#End Region

#Region "Příklad F5"
    'Sestavte funkci Kurs, která má dva parametry: prvním je číslo ve významu korun, druhým je tříznakový řetězec ve významu kódu měny (“EUR“, “USD“, “GBP“), na kterou se tyto koruny mají vyměnit.
    'Výsledkem volání funkce je částka v dané měně, rovnající se danému počtu korun (nebo hodnota -1, jestliže jde o měnu, pro kterou není kurs znám).
    'Kurz bude ve funkci zadán „natvrdo“, např. 27,35 pro euro.
    'Tedy volat se tedy měla např. takto
    'MsgBox kurs(273.5, "EUR")
    'Vypsat by měla 10. Tedy že 255, 3 Kč je 10 Euro. 

    Sub F5()

        Dim korun, smena As Single, mena As String

        Console.WriteLine("Zadejte částku v CZK, kterou chcete směnit")
        korun = Convert.ToSingle(Console.ReadLine())

        Console.WriteLine("Zadejte zkratku měny, na kterou chcete CZK směnit (EUR, USD, GBP)")
        mena = Console.ReadLine()

        mena = UCase(mena)

        smena = Kurs(korun, mena)

        Console.WriteLine("Částka " + Format(korun, "0.00") + " CZK je po převodu " + Format(smena, "0.00") + " " + mena)

    End Sub

    Function Kurs(ByRef korun As Single, ByRef mena As String) As Integer
        Dim smena As Single

        Select Case mena
            Case "EUR"
                smena = korun / 24.7
            Case "USD"
                smena = korun / 21.8
            Case "GBP"
                smena = korun / 29.6
            Case Else
                Console.WriteLine("Neznámá měna...")
        End Select

        Return smena
    End Function

#End Region

#Region "Příklad F6"
    'Funkce, které se předá číslo 1 až 7 a vrací slovně den v týdnu.
    'Vytvořte variantu s Else if i se Select Case.

    Sub F6()
        Dim cislo As Byte, den As String

        Console.WriteLine("Zadejte (číselně 1-7) den v týdnu")
        cislo = Convert.ToByte(Console.ReadLine())
        'den = WeekdayName(cislo)
        den = DenVTydnu(cislo)

        Console.WriteLine("Číslo " + Format(cislo) + " je " + den)

    End Sub

    Function DenVTydnu(ByRef cislo As Byte) As String
        Dim den As String

        Select Case cislo
            Case 1
                den = "Pondělí"
            Case 2
                den = "Úterý"
            Case 3
                den = "Středa"
            Case 4
                den = "Čtvrtek"
            Case 5
                den = "Pátek"
            Case 6
                den = "Sobota"
            Case 7
                den = "Neděle"
            Case Else
                den = "Chyba čísla - zadejte pouze číslo v rozmezí 1-7"
        End Select

        Return den

    End Function

#End Region

#Region "Příklad F7"
    'Funkci se předá znak a funkce vrátí řetězec: „malé písmeno“, „velké písmeno“, „číslice“, „ostatní“.

    Sub F7()
        Dim znak As Char, typ As String

        Console.WriteLine("Zadejte znak pro rozpoznání jeho typu")
        znak = Convert.ToChar(Console.ReadLine())

        typ = TypZnaku(znak)

        Console.WriteLine("Zadaný znak je " + typ)

    End Sub

    Function TypZnaku(ByRef znak As Char) As String
        Dim znakASCII As Byte, typ As String

        znakASCII = Asc(znak)

        If znakASCII >= 48 And znakASCII <= 57 Then
            typ = "číslo"
        ElseIf znakASCII >= 65 And znakASCII <= 90 Then
            typ = "velké písmeno"
        ElseIf znakASCII >= 97 And znakASCII <= 122 Then
            typ = "malé písmeno"
        Else
            typ = "ostatní"
        End If

        Return typ
    End Function

#End Region
End Module
