package main

import "fmt"

type Car struct {
	name string
	kind string
	version int
	price int
}

func (c *Car) talk() {
	fmt.Println("Ben", c.version, "model ", c.name, c.kind, " im.Fiyatım", c.price)
}

func main() {
	c := Car{"Bmw", "3.18", 2014, 100000}
	c.talk()
}