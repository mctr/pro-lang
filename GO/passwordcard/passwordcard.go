package main

import (
	"fmt"
	"github.com/ActiveState/golor"
	"math/rand"
	"strings"
	"time"
)

type Passwordcard struct {
	mixed      []string
	KartNo     string
	kart_mixed []string // Kart Numaralarında sembollerin olmasını istemiyorum
}

func (s *Passwordcard) initialize() {
	// Password kart üzerindeki karakterlerin tümü
	s.mixed =
		strings.Split("0123456789abcdefghjkmnpqrstuvwxyzABCDEFGHJKLMNPQRSTUVWXYZ@#$%&*<>?€+{}[]()/\\", "")
	// Kart Numarasının seçildigi String
	s.kart_mixed = strings.Split("0123456789abcdefghjkmnpqrstuvwxyzABCDEFGHJKLMNPQRSTUVWXYZ", "")
}

func (s *Passwordcard) exchange() {
	rand.Seed(time.Now().UnixNano())

	for k := range s.mixed {
		m := rand.Intn(k + 2)
		s.mixed[k], s.mixed[m] = s.mixed[m], s.mixed[k]
	}

	//Aynı degiştirme işlemini Kart Numarası için de yapıyorum
	for k := range s.kart_mixed {
		m := rand.Intn(k + 1)
		s.kart_mixed[k], s.kart_mixed[m] = s.kart_mixed[m], s.kart_mixed[k]
	}
}

func (s *Passwordcard) print() {
	s.exchange()
	for i := 1; i < 10; i++ {
		fmt.Print(i)
		for d := 0; d < 29; d++ {
			if i == 1 || i == 2 {
				fmt.Print(golor.Colorize(" " + s.mixed[d], -1, golor.GREEN))
			}
			if i == 3 || i == 4 {
				fmt.Print(golor.Colorize(" " + s.mixed[d], -1, golor.MAGENTA))
			}
			if i == 5 || i == 6 {
				fmt.Print(golor.Colorize(" " + s.mixed[d], -1, golor.YELLOW))
			}
			if i == 7 || i == 8 {
				fmt.Print(golor.Colorize(" " + s.mixed[d], -1, golor.RED))
			}
			if i == 9 {
				fmt.Print(golor.Colorize(" " + s.mixed[d], -1, golor.CYAN))
			}
		}
		s.KartNo += s.kart_mixed[6]
		fmt.Println()
		s.exchange()
	}
}

func main() {
	var s Passwordcard
	symbols := "  ■ □ ▲ △ ○ ● ★ ☂ ☀ ☁ ☹ ☺ ♠ ♣ ♥ ♦ ♫ € ¥ £ $ ! ? ¡ ¿ ⊙ ◐ ◩ �"
	fmt.Println(golor.Colorize(symbols, -1, golor.WHITE))

	s.initialize()
	s.print()
	fmt.Println("\t\t Kart Numarası :", s.KartNo)
}
