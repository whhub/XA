// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: GeneralRequestCommand.proto

#ifndef PROTOBUF_GeneralRequestCommand_2eproto__INCLUDED
#define PROTOBUF_GeneralRequestCommand_2eproto__INCLUDED

#include <string>

#include <google/protobuf/stubs/common.h>

#if GOOGLE_PROTOBUF_VERSION < 2004000
#error This file was generated by a newer version of protoc which is
#error incompatible with your Protocol Buffer headers.  Please update
#error your headers.
#endif
#if 2004001 < GOOGLE_PROTOBUF_MIN_PROTOC_VERSION
#error This file was generated by an older version of protoc which is
#error incompatible with your Protocol Buffer headers.  Please
#error regenerate this file with a newer version of protoc.
#endif

#include <google/protobuf/generated_message_util.h>
#include <google/protobuf/repeated_field.h>
#include <google/protobuf/extension_set.h>
#include <google/protobuf/generated_message_reflection.h>
// @@protoc_insertion_point(includes)

namespace UIH {
namespace XR {
namespace Basis {
namespace Proto {

// Internal implementation detail -- do not call these.
void  protobuf_AddDesc_GeneralRequestCommand_2eproto();
void protobuf_AssignDesc_GeneralRequestCommand_2eproto();
void protobuf_ShutdownFile_GeneralRequestCommand_2eproto();

class GeneralRequestCommand;

// ===================================================================

class GeneralRequestCommand : public ::google::protobuf::Message {
 public:
  GeneralRequestCommand();
  virtual ~GeneralRequestCommand();
  
  GeneralRequestCommand(const GeneralRequestCommand& from);
  
  inline GeneralRequestCommand& operator=(const GeneralRequestCommand& from) {
    CopyFrom(from);
    return *this;
  }
  
  inline const ::google::protobuf::UnknownFieldSet& unknown_fields() const {
    return _unknown_fields_;
  }
  
  inline ::google::protobuf::UnknownFieldSet* mutable_unknown_fields() {
    return &_unknown_fields_;
  }
  
  static const ::google::protobuf::Descriptor* descriptor();
  static const GeneralRequestCommand& default_instance();
  
  void Swap(GeneralRequestCommand* other);
  
  // implements Message ----------------------------------------------
  
  GeneralRequestCommand* New() const;
  void CopyFrom(const ::google::protobuf::Message& from);
  void MergeFrom(const ::google::protobuf::Message& from);
  void CopyFrom(const GeneralRequestCommand& from);
  void MergeFrom(const GeneralRequestCommand& from);
  void Clear();
  bool IsInitialized() const;
  
  int ByteSize() const;
  bool MergePartialFromCodedStream(
      ::google::protobuf::io::CodedInputStream* input);
  void SerializeWithCachedSizes(
      ::google::protobuf::io::CodedOutputStream* output) const;
  ::google::protobuf::uint8* SerializeWithCachedSizesToArray(::google::protobuf::uint8* output) const;
  int GetCachedSize() const { return _cached_size_; }
  private:
  void SharedCtor();
  void SharedDtor();
  void SetCachedSize(int size) const;
  public:
  
  ::google::protobuf::Metadata GetMetadata() const;
  
  // nested types ----------------------------------------------------
  
  // accessors -------------------------------------------------------
  
  // required int32 CommandId = 1;
  inline bool has_commandid() const;
  inline void clear_commandid();
  static const int kCommandIdFieldNumber = 1;
  inline ::google::protobuf::int32 commandid() const;
  inline void set_commandid(::google::protobuf::int32 value);
  
  // optional bytes Parameters = 2;
  inline bool has_parameters() const;
  inline void clear_parameters();
  static const int kParametersFieldNumber = 2;
  inline const ::std::string& parameters() const;
  inline void set_parameters(const ::std::string& value);
  inline void set_parameters(const char* value);
  inline void set_parameters(const void* value, size_t size);
  inline ::std::string* mutable_parameters();
  inline ::std::string* release_parameters();
  
  // @@protoc_insertion_point(class_scope:UIH.XR.Basis.Proto.GeneralRequestCommand)
 private:
  inline void set_has_commandid();
  inline void clear_has_commandid();
  inline void set_has_parameters();
  inline void clear_has_parameters();
  
  ::google::protobuf::UnknownFieldSet _unknown_fields_;
  
  ::std::string* parameters_;
  ::google::protobuf::int32 commandid_;
  
  mutable int _cached_size_;
  ::google::protobuf::uint32 _has_bits_[(2 + 31) / 32];
  
  friend void  protobuf_AddDesc_GeneralRequestCommand_2eproto();
  friend void protobuf_AssignDesc_GeneralRequestCommand_2eproto();
  friend void protobuf_ShutdownFile_GeneralRequestCommand_2eproto();
  
  void InitAsDefaultInstance();
  static GeneralRequestCommand* default_instance_;
};
// ===================================================================


// ===================================================================

// GeneralRequestCommand

// required int32 CommandId = 1;
inline bool GeneralRequestCommand::has_commandid() const {
  return (_has_bits_[0] & 0x00000001u) != 0;
}
inline void GeneralRequestCommand::set_has_commandid() {
  _has_bits_[0] |= 0x00000001u;
}
inline void GeneralRequestCommand::clear_has_commandid() {
  _has_bits_[0] &= ~0x00000001u;
}
inline void GeneralRequestCommand::clear_commandid() {
  commandid_ = 0;
  clear_has_commandid();
}
inline ::google::protobuf::int32 GeneralRequestCommand::commandid() const {
  return commandid_;
}
inline void GeneralRequestCommand::set_commandid(::google::protobuf::int32 value) {
  set_has_commandid();
  commandid_ = value;
}

// optional bytes Parameters = 2;
inline bool GeneralRequestCommand::has_parameters() const {
  return (_has_bits_[0] & 0x00000002u) != 0;
}
inline void GeneralRequestCommand::set_has_parameters() {
  _has_bits_[0] |= 0x00000002u;
}
inline void GeneralRequestCommand::clear_has_parameters() {
  _has_bits_[0] &= ~0x00000002u;
}
inline void GeneralRequestCommand::clear_parameters() {
  if (parameters_ != &::google::protobuf::internal::kEmptyString) {
    parameters_->clear();
  }
  clear_has_parameters();
}
inline const ::std::string& GeneralRequestCommand::parameters() const {
  return *parameters_;
}
inline void GeneralRequestCommand::set_parameters(const ::std::string& value) {
  set_has_parameters();
  if (parameters_ == &::google::protobuf::internal::kEmptyString) {
    parameters_ = new ::std::string;
  }
  parameters_->assign(value);
}
inline void GeneralRequestCommand::set_parameters(const char* value) {
  set_has_parameters();
  if (parameters_ == &::google::protobuf::internal::kEmptyString) {
    parameters_ = new ::std::string;
  }
  parameters_->assign(value);
}
inline void GeneralRequestCommand::set_parameters(const void* value, size_t size) {
  set_has_parameters();
  if (parameters_ == &::google::protobuf::internal::kEmptyString) {
    parameters_ = new ::std::string;
  }
  parameters_->assign(reinterpret_cast<const char*>(value), size);
}
inline ::std::string* GeneralRequestCommand::mutable_parameters() {
  set_has_parameters();
  if (parameters_ == &::google::protobuf::internal::kEmptyString) {
    parameters_ = new ::std::string;
  }
  return parameters_;
}
inline ::std::string* GeneralRequestCommand::release_parameters() {
  clear_has_parameters();
  if (parameters_ == &::google::protobuf::internal::kEmptyString) {
    return NULL;
  } else {
    ::std::string* temp = parameters_;
    parameters_ = const_cast< ::std::string*>(&::google::protobuf::internal::kEmptyString);
    return temp;
  }
}


// @@protoc_insertion_point(namespace_scope)

}  // namespace Proto
}  // namespace Basis
}  // namespace XR
}  // namespace UIH

#ifndef SWIG
namespace google {
namespace protobuf {


}  // namespace google
}  // namespace protobuf
#endif  // SWIG

// @@protoc_insertion_point(global_scope)

#endif  // PROTOBUF_GeneralRequestCommand_2eproto__INCLUDED