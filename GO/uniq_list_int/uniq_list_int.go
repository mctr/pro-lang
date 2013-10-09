package main

import "fmt"

func main() {
	result := []int {0}
	int_list := []int {
		2,
		3,
		5,
		4,
		4,
		3,
		3,
		5,
	}
    	for _, v := range int_list {
		state := true
        	for _, k := range result {
			if v != k {
				state = false
			} else if v == k {
				state = true
				break
			}
		}
		if state == false {
				result = append(result, v)
			}
    	}
	result = result[1:]
    	fmt.Println(result)
}
