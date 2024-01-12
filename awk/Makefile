VPATH = src test

.DEFAULT_GOAL:= run

.PHONY: run test TAGs

run:
	@./src/wee.awk input

test:
	@# Toggle lines for colored output
	@# @echo "" | awk -f test/tests.awk | pygmentize -l tap -f terminal256 -O style=friendly
	@echo "" | awk -f test/tests.awk 

TAGS:
	ctags -R

