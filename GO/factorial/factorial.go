package main

import "fmt"

func factorial(x int) int {
	if x == 0 {
		return 1
	}

	return x * factorial(x-1)
}

func main() {

	fmt.Print("Faktöriyel almak istediginiz sayıyı Giriniz : ")
	var i int
	fmt.Scanf("%d", &i)
	//result := factorial(i)
	fmt.Println(factorial(i))
}