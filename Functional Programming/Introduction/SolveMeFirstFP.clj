;; https://www.hackerrank.com/challenges/fp-solve-me-first

(defn solveMeFirst [x y]    
    (+ x y))


(def a (read-line))
(def b (read-line))

(println (solveMeFirst (Integer/parseInt a) (Integer/parseInt b)))
