namespace Backend

module Say =
    open System

    let k1 = 50.0
    let T1 = 0.44
    let k2 = 0.4
    let k3 = 2.5
    let k4 = 1.0
    let T = 0.074
    let k_fb = 1.0
    let k_cb = 1.0
    let T0 = 1.0
    let T3 = 1.0
    let Z_0 = 21.0
    let deltaX1 = 0.5

    let x1' x2 k4 Z =
        k4 * (x2 - Z)

    let x2' x1 x3 k2 k3 T x2 =
        (k2 / T) * (x3 - k3 * x1 ) - (1.0 / T) * x2

    let x3' x_cb k1 T1 x3 =
        (k1 / T1) * x_cb - (1.0 / T1) * x3

    let x_cb' k_cb T0 T3 e x_cb =
        (k_cb / T0) * e - (1.0 / T3) * x_cb

    let e x1 V k_fb =
        V - k_fb * x1

    let rungeKutt x1 x2 x3 x_cb h Z V =
        let e = V - k_fb * x1

        let x1' = x1' x2 k4 Z
        let x2' = x2' x1 x3 k2 k3 T
        let x3' = x3' x_cb k1 T1
        let x_cb' = x_cb' k_cb T0 T3 e

        let y_n1 y_n h k1 k2 k3 k4 =
            y_n + (h / 6.0) * (k1 + 2.0 * k2 + 2.0 * k3 + k4)

        let x1 = y_n1 x1 h x1' x1' x1' x1'
        let x2 =
            let k1 = x2' x2
            let k2 = x2' (x2 + k1 * h/2.0)
            let k3 = x2' (x2 + k2 * h/2.0)
            let k4 = x2' (x2 + k3 * h)
            y_n1 x2 h k1 k2 k3 k4
        let x3 =
            let k1 = x3' x3
            let k2 = x3' (x3 + k1 * h/2.0)
            let k3 = x3' (x3 + k2 * h/2.0)
            let k4 = x3' (x3 + k3 * h)
            y_n1 x2 h k1 k2 k3 k4
        let x_cb =
            let k1 = x_cb' x_cb
            let k2 = x_cb' (x_cb + k1 * h/2.0)
            let k3 = x_cb' (x_cb + k2 * h/2.0)
            let k4 = x_cb' (x_cb + k3 * h)
            y_n1 x2 h k1 k2 k3 k4
        struct(x1, x2, x3, x_cb)


    let createSequence (x1, x2, x3, x_cb, interval, h) =
        let rec recursiveSequence struct(x1, x2, x3, x_cb) h i endi = [
            let Z = 20.0
            let V = 10.0
            let value = rungeKutt x1 x2 x3 x_cb h Z V
            yield value

            if i < endi then yield! recursiveSequence value h (i+1) endi
        ]
        recursiveSequence struct(x1, x2, x3, x_cb) 

    let hello name =
        let printData first last=
            first + " " + last
        
        let printfirst = printData "pidor"

        let result = printfirst name

        printfn "Hello %s" result

        Console.ReadLine()

        
