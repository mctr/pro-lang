package main

import "fmt"

func main() {
	var slice2 []int
	var slice3 []int

	slice1 := []int{1, 2, 3}
	slice2 = append(slice1, 4, 5)
	slice3 = append(slice1, slice2...)
	fmt.Println(slice3)
}
