(
  cd rust
  cargo build
)

mkdir -p unity/Assets/Plugins
cp rust/target/debug/libffi_example.dylib unity/Assets/Plugins/libffi_example.bundle
