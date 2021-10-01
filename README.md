## unity_web
Unity for web

## TODO
- [ ] Make a `helloworld` calling javascript from unity
- [ ] Game canvas: Layout & Fullscreen
- [ ] How to debug?


## How to binding javascript to unity
- Doc: https://emscripten.org/docs/porting/connecting_cpp_and_javascript/Interacting-with-code.html

```js
mergeInto(LibraryManager.library, {
  my_js: function() {
    alert('hi');
  },
});
```

## KQL
- https://medium.com/coinmonks/part-1-using-nethereum-in-unity-54e62f7e65d5
- https://medium.com/coinmonks/part-2-using-nethereum-in-unity-54e62f7e65d5