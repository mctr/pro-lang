package main

import "fmt"

func main() {
	verilen := []int{0}
	args := []int{
		2,
		3,
		5,
		4,
		4,
		3,
		3,
		5,
	}
    	for _, v := range args {
		state := true
        	for _, k := range verilen {
			if v != k {
				state = false
			} else if v == k {
				state = true
				break
			}
		}
		if state == false {
				verilen = append(verilen, v)
			}
    	}
	verilen = verilen[1:]
    	fmt.Println(verilen)
}
