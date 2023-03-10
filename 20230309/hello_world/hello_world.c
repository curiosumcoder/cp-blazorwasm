// https://emscripten.org/docs/getting_started/Tutorial.html#tutorial
// C:\..\emsdk
// .\emsdk_env.ps1
// cd D:\cp-blazorwasm\20230309\hello_world
// emcc -v
// emcc hello_world.c
// node a.out.js
// emcc hello_world.c -o hello.html
/*
 * Copyright 2011 The Emscripten Authors.  All rights reserved.
 * Emscripten is available under two separate licenses, the MIT license and the
 * University of Illinois/NCSA Open Source License.  Both these licenses can be
 * found in the LICENSE file.
 */

#include <stdio.h>

int main() {
  printf("hello, world from WebAssembly!\n");
  return 0;
}