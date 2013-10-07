package main

import "fmt"

func main() {
    sayilar := []float64{12, 34, 56, 97, 34, 76}
    fmt.Println(ortalama(sayilar))
}

func ortalama(sayilar []float64) float64 {    
    toplam := 0.0
    for _, i := range sayilar {
        toplam += i
    }
    return toplam / float64(len(sayilar))
}
