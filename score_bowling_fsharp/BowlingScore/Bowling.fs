module BowlingScore

let IsSpare (lances: int[]) = lances.[0] + lances.[1] = 10

let IsStrick (lances: int[]) = lances.[0] = 10

let rec sum list indexPartie  =
    match Array.length(list) with
    | 0 | 1 -> 0
    | _ -> 
        
        let total(partie, bonus, restant) = partie + bonus + sum restant (indexPartie+1)
        let toutca = 
            if IsStrick(list)  then
                let partie = 10
                let bonus = list.[1] + list.[2]
                (partie, bonus, (if indexPartie < 9 then list.[1..]  else Array.empty))
            else
                let partie = list.[0] + list.[1]
                let bonus = 
                    match IsSpare(list)  with
                    |true -> list.[2] 
                    | _ -> 0
                (partie, bonus, list.[2..])
        total toutca


let CalculScore lances = sum lances 0


