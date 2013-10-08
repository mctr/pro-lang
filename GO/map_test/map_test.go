package main

import "fmt"

func main() {
	word := make(map[string]string)
	word["milk"] = "Süt"
	word["red"] = "Kırmızı"
	word["yellow"] = "Sarı"
	word["door"] = "Kapı"
	word["windows"] = "Pencere"
	word["computer"] = "Bilgisayar"
	
	fmt.Println(word["yellow"])
	fmt.Println(word["red"])
}
