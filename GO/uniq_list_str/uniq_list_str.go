package main

import "fmt"

func main() {
	args := []string {
		"elma",
		"armut",
		"kiraz",
		"karpuz",
		"elma",
		"kiraz",
		"elma",
	}
	result := args[:1]
    	for _, v := range args {
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
