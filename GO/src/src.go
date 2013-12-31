package main

import (
	"fmt"
	"os"
	"os/exec"
	"strings"
)

var incoming_url []string
var SRCDIR string
var full_url string

func set_srcdir() {

	SRCDIR = os.Getenv("SRCDIR")
	if SRCDIR == "" {
		os.MkdirAll(os.Getenv("HOME")+"/"+"src", 0777)
		SRCDIR = os.Getenv("HOME") + "/src"
	}
}

func creating_directory() {
	os.MkdirAll(SRCDIR+"/"+incoming_url[0]+"/"+incoming_url[1], 0777)
}

func full_url_parse() {
	incoming_url = strings.Split(os.Args[1], "/")
}

func create_full_url() {
	if len(os.Args) == 2 {
		full_url = "https://" + incoming_url[0] + "/" + incoming_url[1] + "/" + incoming_url[2] + ".git"
	} else {
		fmt.Println("örnek kullanım: src github.com/mctr/mam")
		os.Exit(-1)
	}
}

func clone_processing() {
	fmt.Println(incoming_url[0] + "/" + incoming_url[1] + "/" + incoming_url[2] + "  getiriliyor...")
	os.Chdir(SRCDIR + "/" + incoming_url[0] + "/" + incoming_url[1])
	_, err := exec.Command("git", "clone", full_url).Output()
	if err != nil {
		fmt.Println(err)
	}
	fmt.Println("\nKlonlama tamamlandı")
}

func main() {
	set_srcdir()
	full_url_parse()
	create_full_url()
	creating_directory()
	clone_processing()
}
