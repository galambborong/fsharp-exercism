module PizzaPricing

type Pizza =
    | Margherita
    | Caprese
    | Formaggio
    | ExtraSauce of Pizza
    | ExtraToppings of Pizza

let rec pizzaPrice pizza =
    match pizza with
    | Margherita -> 7
    | Caprese -> 9
    | Formaggio -> 10
    | ExtraSauce pizza -> (pizzaPrice pizza) + 1
    | ExtraToppings pizza -> (pizzaPrice pizza) + 2

let orderPrice pizzas =
    let pizzaSubTotal = pizzas |> List.sumBy pizzaPrice

    match pizzas.Length with
    | 1 -> pizzaSubTotal + 3
    | 2 -> pizzaSubTotal + 2
    | _ -> pizzaSubTotal
