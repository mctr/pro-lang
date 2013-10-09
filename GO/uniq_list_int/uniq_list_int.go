package main

import "fmt"

func main() {
	int_list := []int {
		2,
		3,
		5,
		4,
		0,
		4,
		3,
		3,
		5,
	}
	result :=int_list[:1]
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
    	fmt.Println(result)
}
